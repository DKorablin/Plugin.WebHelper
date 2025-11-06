#if !NETFRAMEWORK
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace System.Web.UI
{
	/// <summary>LosFormatter compatibility layer for .NET 8 Provides ViewState deserialization functionality</summary>
	public class LosFormatter
	{
		internal ObjectStateFormatter _formatter;

		public LosFormatter()
		{
			_formatter = new ObjectStateFormatter();
		}

		public Object Deserialize(String input)
		{
			if(String.IsNullOrEmpty(input))
				throw new ArgumentNullException(nameof(input));

			try
			{
				Byte[] bytes = Convert.FromBase64String(input);
				using(MemoryStream stream = new MemoryStream(bytes))
					return this._formatter.Deserialize(stream);
			} catch(Exception ex)
			{
				throw new ArgumentException("Failed to deserialize ViewState", nameof(input), ex);
			}
		}

		public Object Deserialize(Stream stream)
		{
			_ = stream ?? throw new ArgumentNullException(nameof(stream));

			return this._formatter.Deserialize(stream);
		}

		public void Serialize(Stream stream, Object value)
		{
			_ = stream ?? throw new ArgumentNullException(nameof(stream));

			this._formatter.Serialize(stream, value);
		}

		public void Serialize(TextWriter output, Object value)
		{
			_ = output ?? throw new ArgumentNullException(nameof(output));

			using(MemoryStream stream = new MemoryStream())
			{
				_formatter.Serialize(stream, value);
				Byte[] bytes = stream.ToArray();
				String base64 = Convert.ToBase64String(bytes);
				output.Write(base64);
			}
		}
	}

	/// <summary>
	/// ObjectStateFormatter compatibility layer for .NET 8 Provides basic object graph serialization for ViewState
	/// </summary>
	public class ObjectStateFormatter
	{
		internal Boolean _throwOnErrorDeserializing = true;

		public ObjectStateFormatter()
		{
		}

		public Object Deserialize(String inputString)
		{
			if(String.IsNullOrEmpty(inputString))
				throw new ArgumentNullException(nameof(inputString));

			Byte[] bytes = Convert.FromBase64String(inputString);
			using(MemoryStream stream = new MemoryStream(bytes))
				return this.Deserialize(stream);
		}

		public Object Deserialize(Stream inputStream)
		{
			_ = inputStream ?? throw new ArgumentNullException(nameof(inputStream));

			try
			{
				using(BinaryReader reader = new BinaryReader(inputStream))
					return this.DeserializeValue(reader);
			} catch(Exception ex)
			{
				if(_throwOnErrorDeserializing)
					throw;

				// Return a simple error marker object
				return new Pair(new IndexedString("Error"), new IndexedString(ex.Message));
			}
		}

		public String Serialize(Object stateGraph)
		{
			using(MemoryStream stream = new MemoryStream())
			{
				Serialize(stream, stateGraph);
				Byte[] bytes = stream.ToArray();
				return Convert.ToBase64String(bytes);
			}
		}

		public void Serialize(Stream outputStream, Object stateGraph)
		{
			_ = outputStream ?? throw new ArgumentNullException(nameof(outputStream));

			using(BinaryWriter writer = new BinaryWriter(outputStream, Encoding.UTF8, true))
				this.SerializeValue(writer, stateGraph);
		}

		private Object DeserializeValue(BinaryReader reader)
		{
			Byte token = reader.ReadByte();

			switch (token)
			{
				case 1: // null
					return null;
				case 2: // IndexedString
					return new IndexedString(reader.ReadString());
				case 3: // String
					return reader.ReadString();
				case 4: // Int32
					return reader.ReadInt32();
				case 5: // Byte
					return reader.ReadByte();
				case 6: // Char
					return reader.ReadChar();
				case 7: // DateTime
					return new DateTime(reader.ReadInt64());
				case 8: // Double
					return reader.ReadDouble();
				case 9: // Single
					return reader.ReadSingle();
				case 10: // Boolean
					return reader.ReadBoolean();
				case 11: // Decimal
					return Decimal.Parse(reader.ReadString());
				case 12: // Int16
					return reader.ReadInt16();
				case 13: // Int64
					return reader.ReadInt64();
				case 14: // Pair
					{
						Object first = DeserializeValue(reader);
						Object second = DeserializeValue(reader);
						return new Pair(first, second);
					}
				case 15: // Triplet
					{
						Object first = DeserializeValue(reader);
						Object second = DeserializeValue(reader);
						Object third = DeserializeValue(reader);
						return new Triplet(first, second, third);
					}
				case 16: // ArrayList
					{
						Int32 count = reader.ReadInt32();
						System.Collections.ArrayList list = new System.Collections.ArrayList(count);
						for (Int32 i = 0; i < count; i++)
							list.Add(this.DeserializeValue(reader));
						return list;
					}
				case 17: // HashTable
					{
						Int32 count = reader.ReadInt32();
						System.Collections.Hashtable table = new System.Collections.Hashtable(count);
						for (Int32 i = 0; i < count; i++)
						{
							Object key = this.DeserializeValue(reader);
							Object value = this.DeserializeValue(reader);
							table.Add(key, value);
						}
						return table;
					}
				case 18: // Array
					{
						Int32 count = reader.ReadInt32();
						Object[] array = new Object[count];
						for (Int32 i = 0; i < count; i++)
							array[i] = this.DeserializeValue(reader);
						return array;
					}
				case 50: // byte[]
					{
						Int32 length = reader.ReadInt32();
						return reader.ReadBytes(length);
					}
				default:
					// Unknown type - try to read as string
					if (!_throwOnErrorDeserializing)
						return new IndexedString($"Unknown type token: {token}");
					throw new InvalidOperationException($"Unknown serialization token: {token}");
			}
		}

		private void SerializeValue(BinaryWriter writer, Object value)
		{
			if (value == null)
			{
				writer.Write((Byte)1);
				return;
			}

			Type type = value.GetType();

			if (value is IndexedString indexedString)
			{
				writer.Write((Byte)2);
				writer.Write(indexedString.Value);
			}
			else if (type == typeof(String))
			{
				writer.Write((Byte)3);
				writer.Write((String)value);
			}
			else if (type == typeof(Int32))
			{
				writer.Write((Byte)4);
				writer.Write((Int32)value);
			}
			else if (type == typeof(Byte))
			{
				writer.Write((Byte)5);
				writer.Write((Byte)value);
			}
			else if (type == typeof(Char))
			{
				writer.Write((Byte)6);
				writer.Write((Char)value);
			}
			else if (type == typeof(DateTime))
			{
				writer.Write((Byte)7);
				writer.Write(((DateTime)value).Ticks);
			}
			else if (type == typeof(Double))
			{
				writer.Write((Byte)8);
				writer.Write((Double)value);
			}
			else if (type == typeof(Single))
			{
				writer.Write((Byte)9);
				writer.Write((Single)value);
			}
			else if (type == typeof(Boolean))
			{
				writer.Write((Byte)10);
				writer.Write((Boolean)value);
			}
			else if (type == typeof(Decimal))
			{
				writer.Write((Byte)11);
				writer.Write(value.ToString());
			}
			else if (type == typeof(Int16))
			{
				writer.Write((Byte)12);
				writer.Write((Int16)value);
			}
			else if (type == typeof(Int64))
			{
				writer.Write((Byte)13);
				writer.Write((Int64)value);
			}
			else if (value is Pair pair)
			{
				writer.Write((Byte)14);
				this.SerializeValue(writer, pair.First);
				this.SerializeValue(writer, pair.Second);
			}
			else if (value is Triplet triplet)
			{
				writer.Write((Byte)15);
				this.SerializeValue(writer, triplet.First);
				this.SerializeValue(writer, triplet.Second);
				this.SerializeValue(writer, triplet.Third);
			}
			else if (value is System.Collections.ArrayList arrayList)
			{
				writer.Write((Byte)16);
				writer.Write(arrayList.Count);
				foreach (Object item in arrayList)
					this.SerializeValue(writer, item);
			}
			else if (value is System.Collections.Hashtable hashTable)
			{
				writer.Write((Byte)17);
				writer.Write(hashTable.Count);
				foreach (System.Collections.DictionaryEntry entry in hashTable)
				{
					this.SerializeValue(writer, entry.Key);
					this.SerializeValue(writer, entry.Value);
				}
			}
			else if (value is Array array)
			{
				writer.Write((Byte)18);
				writer.Write(array.Length);
				foreach (Object item in array)
					this.SerializeValue(writer, item);
			}
			else if (type == typeof(Byte[]))
			{
				Byte[] bytes = (Byte[])value;
				writer.Write((Byte)50);
				writer.Write(bytes.Length);
				writer.Write(bytes);
			}
			else
			{
				// Fallback to string representation
				writer.Write((Byte)3);
				writer.Write(value.ToString());
			}
		}
	}
}
#endif