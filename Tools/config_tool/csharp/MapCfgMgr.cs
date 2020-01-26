// Generated by github.com/davyxu/tabtoy
// Version: 2.9.0
// DO NOT EDIT!!
using System.Collections.Generic;

namespace DC
{
	
	

	// Defined in table: MapCfgMgr
	
	public partial class MapCfgMgr
	{
	
		public tabtoy.Logger TableLogger = new tabtoy.Logger();
	
		
		/// <summary> 
		/// MapConfig
		/// </summary>
		public List<MapConfigDefine> MapConfig = new List<MapConfigDefine>(); 
	
	
		#region Index code
	 	Dictionary<int, MapConfigDefine> _MapConfigByID = new Dictionary<int, MapConfigDefine>();
        public MapConfigDefine GetMapConfigByID(int ID, MapConfigDefine def = default(MapConfigDefine))
        {
            MapConfigDefine ret;
            if ( _MapConfigByID.TryGetValue( ID, out ret ) )
            {
                return ret;
            }
			
			if ( def == default(MapConfigDefine) )
			{
				TableLogger.ErrorLine("GetMapConfigByID failed, ID: {0}", ID);
			}

            return def;
        }
		
		public string GetBuildID(){
			return "d41d8cd98f00b204e9800998ecf8427e";
		}
	
		#endregion
		#region Deserialize code
		
		static tabtoy.DeserializeHandler<MapCfgMgr> _MapCfgMgrDeserializeHandler;
		static tabtoy.DeserializeHandler<MapCfgMgr> MapCfgMgrDeserializeHandler
		{
			get
			{
				if (_MapCfgMgrDeserializeHandler == null )
				{
					_MapCfgMgrDeserializeHandler = new tabtoy.DeserializeHandler<MapCfgMgr>(Deserialize);
				}

				return _MapCfgMgrDeserializeHandler;
			}
		}
		public static void Deserialize( MapCfgMgr ins, tabtoy.DataReader reader )
		{
			
 			int tag = -1;
            while ( -1 != (tag = reader.ReadTag()))
            {
                switch (tag)
                { 
                	case 0xa0000:
                	{
						ins.MapConfig.Add( reader.ReadStruct<MapConfigDefine>(MapConfigDefineDeserializeHandler) );
                	}
                	break; 
                }
             } 

			
			// Build MapConfig Index
			for( int i = 0;i< ins.MapConfig.Count;i++)
			{
				var element = ins.MapConfig[i];
				
				ins._MapConfigByID.Add(element.ID, element);
				
			}
			
		}
		static tabtoy.DeserializeHandler<MapConfigDefine> _MapConfigDefineDeserializeHandler;
		static tabtoy.DeserializeHandler<MapConfigDefine> MapConfigDefineDeserializeHandler
		{
			get
			{
				if (_MapConfigDefineDeserializeHandler == null )
				{
					_MapConfigDefineDeserializeHandler = new tabtoy.DeserializeHandler<MapConfigDefine>(Deserialize);
				}

				return _MapConfigDefineDeserializeHandler;
			}
		}
		public static void Deserialize( MapConfigDefine ins, tabtoy.DataReader reader )
		{
			
 			int tag = -1;
            while ( -1 != (tag = reader.ReadTag()))
            {
                switch (tag)
                { 
                	case 0x10000:
                	{
						ins.ID = reader.ReadInt32();
                	}
                	break; 
                	case 0x60001:
                	{
						ins.Name = reader.ReadString();
                	}
                	break; 
                	case 0x60002:
                	{
						ins.AssetPath = reader.ReadString();
                	}
                	break; 
                }
             } 

			
		}
		#endregion
	

	} 

	// Defined in table: MapConfig
	[System.Serializable]
	public partial class MapConfigDefine
	{
	
		
		/// <summary> 
		/// ID
		/// </summary>
		public int ID = 0; 
		
		/// <summary> 
		/// 名称
		/// </summary>
		public string Name = ""; 
		
		/// <summary> 
		/// 资源路径
		/// </summary>
		public string AssetPath = ""; 
	
	

	} 

}