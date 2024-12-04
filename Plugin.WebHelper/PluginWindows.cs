using System;
using System.Collections.Generic;
using System.Diagnostics;
using SAL.Flatbed;
using SAL.Windows;

namespace Plugin.WebHelper
{
	public class PluginWindows : IPlugin, IPluginSettings<PluginSettings>
	{
		private TraceSource _trace;
		private PluginSettings _settings;
		private Dictionary<String, DockState> _documentTypes;
		private List<IMenuItem> _networkMenu;

		internal TraceSource Trace
			=> this._trace ?? (this._trace = PluginWindows.CreateTraceSource<PluginWindows>());

		internal IHostWindows HostWindows { get; }

		/// <summary>Настройки для взаимодействия из хоста</summary>
		Object IPluginSettings.Settings
			=> this.Settings;

		/// <summary>Настройки для взаимодействия из плагина</summary>
		public PluginSettings Settings
		{
			get
			{
				if(this._settings == null)
				{
					this._settings = new PluginSettings();
					this.HostWindows.Plugins.Settings(this).LoadAssemblyParameters(this._settings);
				}
				return this._settings;
			}
		}

		private Dictionary<String, DockState> DocumentTypes
		{
			get
			{
				if(this._documentTypes == null)
					this._documentTypes = new Dictionary<String, DockState>()
					{
						{ typeof(PanelHash).ToString(), DockState.DockRightAutoHide },
						{ typeof(PanelWebRequest).ToString(), DockState.DockRightAutoHide },
						{ typeof(PanelImage2Base64).ToString(), DockState.DockRightAutoHide },
						{ typeof(DocumentViewState).ToString(), DockState.Document },
						{ typeof(DocumentAspTicket).ToString(), DockState.Document },
						{ typeof(PanelIpCalculator).ToString(), DockState.DockBottomAutoHide },
					};
				return this._documentTypes;
			}
		}

		public PluginWindows(IHostWindows hostWindows)
			=> this.HostWindows = hostWindows ?? throw new ArgumentNullException(nameof(hostWindows));

		public IWindow GetPluginControl(String typeName, Object args)
			=> this.CreateWindow(typeName, false, args);

		Boolean IPlugin.OnConnection(ConnectMode mode)
		{
			IMenuItem menuTools = this.HostWindows.MainMenu.FindMenuItem("Tools");
			if(menuTools == null)
			{
				this.Trace.TraceEvent(TraceEventType.Error, 10, "Menu item 'Tools' not found");
				return false;
			}

			IMenuItem wwwTools = menuTools.FindMenuItem("Network");
			if(wwwTools == null)
			{
				wwwTools = menuTools.Create("Network");
				wwwTools.Name = "Tools.Network";
				menuTools.Items.Add(wwwTools);
			}

			this._networkMenu = new List<IMenuItem>();
			IMenuItem hashMenu = wwwTools.Create("Hash");
			hashMenu.Name = "Tools.Network.Hash";
			hashMenu.Click += (sender, e)=> { this.CreateWindow(typeof(PanelHash).ToString(), false); };
			this._networkMenu.Add(hashMenu);

			/*IMenuItem aspTicketMenu = wwwTools.Create("ASP.NET Ticket");
			aspTicketMenu.Name = "tsmiNetworkAspTicket";
			aspTicketMenu.Click += (sender, e) => { this.CreateWindow(typeof(DocumentAspTicket).ToString(), false); };
			this._networkMenu.Add(aspTicketMenu);*/

			IMenuItem viewStateMenu = wwwTools.Create("ViewSate Decoder");
			viewStateMenu.Name = "Tools.Network.ViewState";
			viewStateMenu.Click += (sender, e)=> { this.CreateWindow(typeof(DocumentViewState).ToString(), false); };
			this._networkMenu.Add(viewStateMenu);

			/*IMenuItem webRequestMenu = wwwTools.Create("Web Request");
			webRequestMenu.Name = "tsmiNetworkWebRequest";
			webRequestMenu.Click += (sender, e) => { this.CreateWindow(typeof(PanelWebRequest).ToString(), false); };
			this._networkMenu.Add(webRequestMenu);*/

			IMenuItem image2Base64 = wwwTools.Create("Image to Base64");
			image2Base64.Name = "Tools.Network.Image2Base64";
			image2Base64.Click += (sender, e) => { this.CreateWindow(typeof(PanelImage2Base64).ToString(), false); };
			this._networkMenu.Add(image2Base64);

			IMenuItem ipMenu = wwwTools.Create("&IP Calculator");
			ipMenu.Name = "Tools.Network.IpCalculator";
			ipMenu.Click += (sender, e) => { this.CreateWindow(typeof(PanelIpCalculator).ToString(), true); };
			this._networkMenu.Add(ipMenu);

			wwwTools.Items.AddRange(this._networkMenu.ToArray());
			return true;
		}

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
		{
			if(this._networkMenu != null)
				foreach(IMenuItem item in this._networkMenu)
					this.HostWindows.MainMenu.Items.Remove(item);
			return true;
		}

		private IWindow CreateWindow(String typeName, Boolean searchForOpened, Object args = null)
			=> this.DocumentTypes.TryGetValue(typeName, out DockState state)
				? this.HostWindows.Windows.CreateWindow(this, typeName, searchForOpened, state, args)
				: null;

		private static TraceSource CreateTraceSource<T>(String name = null) where T : IPlugin
		{
			TraceSource result = new TraceSource(typeof(T).Assembly.GetName().Name + name);
			result.Switch.Level = SourceLevels.All;
			result.Listeners.Remove("Default");
			result.Listeners.AddRange(System.Diagnostics.Trace.Listeners);
			return result;
		}
	}
}