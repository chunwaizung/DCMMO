// Generated by github.com/davyxu/tabtoy
// Version: 2.9.0
// DO NOT EDIT!!
using System.Collections.Generic;

namespace DC
{
	
	

	// Defined in table: LevelCfgMgr
	
	public partial class LevelCfgMgr
	{
	
		public tabtoy.Logger TableLogger = new tabtoy.Logger();
	
		
		/// <summary> 
		/// LevelConfig
		/// </summary>
		public List<LevelConfigDefine> LevelConfig = new List<LevelConfigDefine>(); 
	
	
		#region Index code
	 	Dictionary<int, LevelConfigDefine> _LevelConfigByID = new Dictionary<int, LevelConfigDefine>();
        public LevelConfigDefine GetLevelConfigByID(int ID, LevelConfigDefine def = default(LevelConfigDefine))
        {
            LevelConfigDefine ret;
            if ( _LevelConfigByID.TryGetValue( ID, out ret ) )
            {
                return ret;
            }
			
			if ( def == default(LevelConfigDefine) )
			{
				TableLogger.ErrorLine("GetLevelConfigByID failed, ID: {0}", ID);
			}

            return def;
        }
		
		public string GetBuildID(){
			return "d41d8cd98f00b204e9800998ecf8427e";
		}
	
		#endregion
		#region Deserialize code
		
		static tabtoy.DeserializeHandler<LevelCfgMgr> _LevelCfgMgrDeserializeHandler;
		static tabtoy.DeserializeHandler<LevelCfgMgr> LevelCfgMgrDeserializeHandler
		{
			get
			{
				if (_LevelCfgMgrDeserializeHandler == null )
				{
					_LevelCfgMgrDeserializeHandler = new tabtoy.DeserializeHandler<LevelCfgMgr>(Deserialize);
				}

				return _LevelCfgMgrDeserializeHandler;
			}
		}
		public static void Deserialize( LevelCfgMgr ins, tabtoy.DataReader reader )
		{
			
 			int tag = -1;
            while ( -1 != (tag = reader.ReadTag()))
            {
                switch (tag)
                { 
                	case 0xa0000:
                	{
						ins.LevelConfig.Add( reader.ReadStruct<LevelConfigDefine>(LevelConfigDefineDeserializeHandler) );
                	}
                	break; 
                }
             } 

			
			// Build LevelConfig Index
			for( int i = 0;i< ins.LevelConfig.Count;i++)
			{
				var element = ins.LevelConfig[i];
				
				ins._LevelConfigByID.Add(element.ID, element);
				
			}
			
		}
		static tabtoy.DeserializeHandler<LevelConfigDefine> _LevelConfigDefineDeserializeHandler;
		static tabtoy.DeserializeHandler<LevelConfigDefine> LevelConfigDefineDeserializeHandler
		{
			get
			{
				if (_LevelConfigDefineDeserializeHandler == null )
				{
					_LevelConfigDefineDeserializeHandler = new tabtoy.DeserializeHandler<LevelConfigDefine>(Deserialize);
				}

				return _LevelConfigDefineDeserializeHandler;
			}
		}
		public static void Deserialize( LevelConfigDefine ins, tabtoy.DataReader reader )
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
                	case 0x10002:
                	{
						ins.MapId = reader.ReadInt32();
                	}
                	break; 
                }
             } 

			
		}
		#endregion
	

	} 

	// Defined in table: LevelConfig
	[System.Serializable]
	public partial class LevelConfigDefine
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
		/// 地图id
		/// </summary>
		public int MapId = 0; 
	
	

	} 

}
