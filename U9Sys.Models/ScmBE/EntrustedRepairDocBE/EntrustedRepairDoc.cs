using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UFIDA.U9.Base.Doc;

namespace SV.Scm.ScmBE.EntrustedRepairDocBE
{
	
	/// <summary>
	/// 实体: 委托维修单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class EntrustedRepairDoc : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public EntrustedRepairDoc(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static EntrustedRepairDoc Create() {
			EntrustedRepairDoc entity = (EntrustedRepairDoc)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																										 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected EntrustedRepairDoc(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static EntrustedRepairDoc CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static EntrustedRepairDoc CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class EntrustedRepairDoc EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new EntrustedRepairDoc GetEntity()
			{
				return (EntrustedRepairDoc)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<EntrustedRepairDoc> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









			/// <summary>
			/// 业务主键查询参数类型
			/// </summary>
			public class BusinessKeyParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public EntrustedRepairDoc FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public EntrustedRepairDoc FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public EntrustedRepairDoc FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// SV_Scm_ScmBE_EntrustedRepairDocBE_EntrustedRepairDoc_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引SV_Scm_ScmBE_EntrustedRepairDocBE_EntrustedRepairDoc_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public EntrustedRepairDoc FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<EntrustedRepairDoc>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal:  UFIDA.U9.Base.Doc.Doc.EntityOriginal
		{
		    //private EntrustedRepairDoc ContainerEntity ;
		    public  new EntrustedRepairDoc ContainerEntity 
		    {
				get { return  (EntrustedRepairDoc)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(EntrustedRepairDoc container):base(container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据类型 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType SVDocType
			{
				get
				{
					if (SVDocTypeKey == null)
						return null ;
					SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType value =  (SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType)SVDocTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey m_SVDocTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey SVDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("SVDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SVDocTypeKey==null || m_SVDocTypeKey.ID != key )
					m_SVDocTypeKey = new SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey(key); 
				return m_SVDocTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 受托站点 (该属性不可为空,且无默认值)
			/// 委托维修单.Misc.受托站点
			/// </summary>
			/// <value></value>
			public  SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite BeEntrustedSite
			{
				get
				{
					if (BeEntrustedSiteKey == null)
						return null ;
					SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite value =  (SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite)BeEntrustedSiteKey.GetEntity();
					return value ;
				}
			}
		


   		private SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey m_BeEntrustedSiteKey ;
		/// <summary>
		/// EntityKey 属性
		/// 受托站点 的Key (该属性不可为空,且无默认值)
		/// 委托维修单.Misc.受托站点
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey BeEntrustedSiteKey
		{
			get 
			{
				object obj = base.GetValue("BeEntrustedSite") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BeEntrustedSiteKey==null || m_BeEntrustedSiteKey.ID != key )
					m_BeEntrustedSiteKey = new SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey(key); 
				return m_BeEntrustedSiteKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 满意度备注 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.满意度备注
			/// </summary>
			/// <value></value>
			public  System.String SatisfactionRemark
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SatisfactionRemark");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客姓名 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客姓名
			/// </summary>
			/// <value></value>
			public  System.String CustomerName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客手机 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客手机
			/// </summary>
			/// <value></value>
			public  System.String CustomerPhone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerPhone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客地址省 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客地址省
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Province CustomerProvince
			{
				get
				{
					if (CustomerProvinceKey == null)
						return null ;
					UFIDA.U9.Base.Location.Province value =  (UFIDA.U9.Base.Location.Province)CustomerProvinceKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Province.EntityKey m_CustomerProvinceKey ;
		/// <summary>
		/// EntityKey 属性
		/// 顾客地址省 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址省
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Province.EntityKey CustomerProvinceKey
		{
			get 
			{
				object obj = base.GetValue("CustomerProvince") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerProvinceKey==null || m_CustomerProvinceKey.ID != key )
					m_CustomerProvinceKey = new UFIDA.U9.Base.Location.Province.EntityKey(key); 
				return m_CustomerProvinceKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客地址市 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客地址市
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.City CustomerCity
			{
				get
				{
					if (CustomerCityKey == null)
						return null ;
					UFIDA.U9.Base.Location.City value =  (UFIDA.U9.Base.Location.City)CustomerCityKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.City.EntityKey m_CustomerCityKey ;
		/// <summary>
		/// EntityKey 属性
		/// 顾客地址市 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址市
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.City.EntityKey CustomerCityKey
		{
			get 
			{
				object obj = base.GetValue("CustomerCity") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerCityKey==null || m_CustomerCityKey.ID != key )
					m_CustomerCityKey = new UFIDA.U9.Base.Location.City.EntityKey(key); 
				return m_CustomerCityKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客地址区 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客地址区
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.County CustomerDistrict
			{
				get
				{
					if (CustomerDistrictKey == null)
						return null ;
					UFIDA.U9.Base.Location.County value =  (UFIDA.U9.Base.Location.County)CustomerDistrictKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.County.EntityKey m_CustomerDistrictKey ;
		/// <summary>
		/// EntityKey 属性
		/// 顾客地址区 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.County.EntityKey CustomerDistrictKey
		{
			get 
			{
				object obj = base.GetValue("CustomerDistrict") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerDistrictKey==null || m_CustomerDistrictKey.ID != key )
					m_CustomerDistrictKey = new UFIDA.U9.Base.Location.County.EntityKey(key); 
				return m_CustomerDistrictKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 顾客地址 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.顾客地址
			/// </summary>
			/// <value></value>
			public  System.String CustomerAdd
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerAdd");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 故障信息 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.故障信息
			/// </summary>
			/// <value></value>
			public  System.String FaultDescription
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FaultDescription");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.物料
			/// </summary>
			/// <value></value>
			public  SV.Pub.PubBE.Item.ItemPartBE.ItemPart ItemPart
			{
				get
				{
					if (ItemPartKey == null)
						return null ;
					SV.Pub.PubBE.Item.ItemPartBE.ItemPart value =  (SV.Pub.PubBE.Item.ItemPartBE.ItemPart)ItemPartKey.GetEntity();
					return value ;
				}
			}
		


   		private SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey m_ItemPartKey ;
		/// <summary>
		/// EntityKey 属性
		/// 物料 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.物料
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey ItemPartKey
		{
			get 
			{
				object obj = base.GetValue("ItemPart") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemPartKey==null || m_ItemPartKey.ID != key )
					m_ItemPartKey = new SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey(key); 
				return m_ItemPartKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal ItemQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ItemQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// SN号 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.SN号
			/// </summary>
			/// <value></value>
			public  System.String SN
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SN");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 维修方案 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.维修方案
			/// </summary>
			/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum MaintenancePlan
			{
				get
				{

					SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum.GetFromValue(base.GetValue("MaintenancePlan"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 委托费用 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.委托费用
			/// </summary>
			/// <value></value>
			public  System.Decimal EntrustedAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("EntrustedAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 委托费用备注 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.委托费用备注
			/// </summary>
			/// <value></value>
			public  System.String EntrustedAmountRemark
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EntrustedAmountRemark");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实测故障 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.实测故障
			/// </summary>
			/// <value></value>
			public  System.String MeasuredFault
			{
				get
				{
					System.String value  = (System.String)base.GetValue("MeasuredFault");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 服务方式 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.服务方式
			/// </summary>
			/// <value></value>
			public  System.String MaintenanceMethod
			{
				get
				{
					System.String value  = (System.String)base.GetValue("MaintenanceMethod");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 维修完成 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.维修完成
			/// </summary>
			/// <value></value>
			public  System.Boolean IsCompleteRepair
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsCompleteRepair");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 满意度 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.满意度
			/// </summary>
			/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum Satisfaction
			{
				get
				{

					SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum.GetFromValue(base.GetValue("Satisfaction"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已支付 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.已支付
			/// </summary>
			/// <value></value>
			public  System.Boolean IsPay
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsPay");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 支付金额 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.支付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal PayAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PayAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 撤销支付 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.撤销支付
			/// </summary>
			/// <value></value>
			public  System.Boolean IsRefund
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsRefund");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 撤销金额 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.撤销金额
			/// </summary>
			/// <value></value>
			public  System.Decimal RefundAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("RefundAmount");
					return value;
						}
			}
		



				

			private SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo.PropertyOriginal m_SrcDocInfo ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据信息 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.来源单据信息
			/// </summary>
			/// <value></value>
			public  SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo.PropertyOriginal SrcDocInfo
			{
				get
				{
					if (m_SrcDocInfo == null )
						m_SrcDocInfo = new SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo.PropertyOriginal(this.ContainerEntity.OriginalData, "SrcDocInfo");
					return m_SrcDocInfo;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据状态 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.单据状态
			/// </summary>
			/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum DocState
			{
				get
				{

					SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum.GetFromValue(base.GetValue("DocState"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前节点 (该属性可为空,但有默认值)
			/// 委托维修单.Misc.当前节点
			/// </summary>
			/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum CurrentNode
			{
				get
				{

					SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum.GetFromValue(base.GetValue("CurrentNode"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 委托内容 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.委托内容
			/// </summary>
			/// <value></value>
			public  System.String EntrustmentConten
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EntrustmentConten");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 终止原因 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.终止原因
			/// </summary>
			/// <value></value>
			public  System.String TerminationReason
			{
				get
				{
					System.String value  = (System.String)base.GetValue("TerminationReason");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics> m_EntrustedRepairLogistics  ;
			/// <summary>
			/// 物流信息 (该属性可为空,且无默认值)
			/// 委托维修单.Misc.物流信息
			/// </summary>
			/// <value></value>
			public  List<SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics> EntrustedRepairLogistics
			{
				get
				{
					if (m_EntrustedRepairLogistics == null)
						m_EntrustedRepairLogistics = new List<SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics>();
					m_EntrustedRepairLogistics.Clear();	
					foreach (SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics child in ContainerEntity.EntrustedRepairLogistics)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_EntrustedRepairLogistics.Add(child);
					}
					foreach (SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics child in ContainerEntity.EntrustedRepairLogistics.DelLists)
					{
						m_EntrustedRepairLogistics.Add(child);
					}
					return m_EntrustedRepairLogistics;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType SVDocType
		{
			get
			{
				object  obj = this.GetRelation("SVDocType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType value  = (SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SVDocType", value);
					 
			}
		}
	


   		private SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey m_SVDocTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey SVDocTypeKey
		{
			get 
			{
				object obj = base.GetValue("SVDocType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SVDocTypeKey==null || m_SVDocTypeKey.ID != key )
					m_SVDocTypeKey = new SV.Pub.PubBE.BA.BPDocTypeBE.BPDocType.EntityKey(key); 
				return m_SVDocTypeKey ;
			}
			set
			{	
				if (SVDocTypeKey==value)
					return ;
				this.SetRelation("SVDocType", null);
				m_SVDocTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("SVDocType",value.ID);
				}
				else
					base.SetValue("SVDocType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 受托站点 (该属性不可为空,且无默认值)
		/// 委托维修单.Misc.受托站点
		/// </summary>
		/// <value></value>
			public  SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite BeEntrustedSite
		{
			get
			{
				object  obj = this.GetRelation("BeEntrustedSite");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite value  = (SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BeEntrustedSite", value);
					 
			}
		}
	


   		private SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey m_BeEntrustedSiteKey ;
		/// <summary>
		/// 受托站点 的Key (该属性不可为空,且无默认值)
		/// 委托维修单.Misc.受托站点
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey BeEntrustedSiteKey
		{
			get 
			{
				object obj = base.GetValue("BeEntrustedSite") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BeEntrustedSiteKey==null || m_BeEntrustedSiteKey.ID != key )
					m_BeEntrustedSiteKey = new SV.Pub.PubBE.CN.ChannelSiteBE.ChannelSite.EntityKey(key); 
				return m_BeEntrustedSiteKey ;
			}
			set
			{	
				if (BeEntrustedSiteKey==value)
					return ;
				this.SetRelation("BeEntrustedSite", null);
				m_BeEntrustedSiteKey = value ;
				if (value != null) 
				{
					base.SetValue("BeEntrustedSite",value.ID);
				}
				else
					base.SetValue("BeEntrustedSite",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 满意度备注 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.满意度备注
		/// </summary>
		/// <value></value>
			public  System.String SatisfactionRemark
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SatisfactionRemark");
				return value;
				}
				set
			{
				
								base.SetValue("SatisfactionRemark", value);
						 
			}
		}
	



		
			/// <summary>
		/// 顾客姓名 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客姓名
		/// </summary>
		/// <value></value>
			public  System.String CustomerName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerName");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 顾客手机 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客手机
		/// </summary>
		/// <value></value>
			public  System.String CustomerPhone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerPhone");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerPhone", value);
						 
			}
		}
	



		
			/// <summary>
		/// 顾客地址省 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址省
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Province CustomerProvince
		{
			get
			{
				object  obj = this.GetRelation("CustomerProvince");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Province value  = (UFIDA.U9.Base.Location.Province)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustomerProvince", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Province.EntityKey m_CustomerProvinceKey ;
		/// <summary>
		/// 顾客地址省 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址省
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Province.EntityKey CustomerProvinceKey
		{
			get 
			{
				object obj = base.GetValue("CustomerProvince") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerProvinceKey==null || m_CustomerProvinceKey.ID != key )
					m_CustomerProvinceKey = new UFIDA.U9.Base.Location.Province.EntityKey(key); 
				return m_CustomerProvinceKey ;
			}
			set
			{	
				if (CustomerProvinceKey==value)
					return ;
				this.SetRelation("CustomerProvince", null);
				m_CustomerProvinceKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomerProvince",value.ID);
				}
				else
					base.SetValue("CustomerProvince",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 顾客地址市 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址市
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.City CustomerCity
		{
			get
			{
				object  obj = this.GetRelation("CustomerCity");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.City value  = (UFIDA.U9.Base.Location.City)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustomerCity", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.City.EntityKey m_CustomerCityKey ;
		/// <summary>
		/// 顾客地址市 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址市
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.City.EntityKey CustomerCityKey
		{
			get 
			{
				object obj = base.GetValue("CustomerCity") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerCityKey==null || m_CustomerCityKey.ID != key )
					m_CustomerCityKey = new UFIDA.U9.Base.Location.City.EntityKey(key); 
				return m_CustomerCityKey ;
			}
			set
			{	
				if (CustomerCityKey==value)
					return ;
				this.SetRelation("CustomerCity", null);
				m_CustomerCityKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomerCity",value.ID);
				}
				else
					base.SetValue("CustomerCity",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 顾客地址区 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址区
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.County CustomerDistrict
		{
			get
			{
				object  obj = this.GetRelation("CustomerDistrict");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.County value  = (UFIDA.U9.Base.Location.County)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustomerDistrict", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.County.EntityKey m_CustomerDistrictKey ;
		/// <summary>
		/// 顾客地址区 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.County.EntityKey CustomerDistrictKey
		{
			get 
			{
				object obj = base.GetValue("CustomerDistrict") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerDistrictKey==null || m_CustomerDistrictKey.ID != key )
					m_CustomerDistrictKey = new UFIDA.U9.Base.Location.County.EntityKey(key); 
				return m_CustomerDistrictKey ;
			}
			set
			{	
				if (CustomerDistrictKey==value)
					return ;
				this.SetRelation("CustomerDistrict", null);
				m_CustomerDistrictKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomerDistrict",value.ID);
				}
				else
					base.SetValue("CustomerDistrict",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 顾客地址 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.顾客地址
		/// </summary>
		/// <value></value>
			public  System.String CustomerAdd
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerAdd");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerAdd", value);
						 
			}
		}
	



		
			/// <summary>
		/// 故障信息 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.故障信息
		/// </summary>
		/// <value></value>
			public  System.String FaultDescription
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FaultDescription");
				return value;
				}
				set
			{
				
								base.SetValue("FaultDescription", value);
						 
			}
		}
	



		
			/// <summary>
		/// 物料 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.物料
		/// </summary>
		/// <value></value>
			public  SV.Pub.PubBE.Item.ItemPartBE.ItemPart ItemPart
		{
			get
			{
				object  obj = this.GetRelation("ItemPart");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					SV.Pub.PubBE.Item.ItemPartBE.ItemPart value  = (SV.Pub.PubBE.Item.ItemPartBE.ItemPart)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ItemPart", value);
					 
			}
		}
	


   		private SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey m_ItemPartKey ;
		/// <summary>
		/// 物料 的Key (该属性可为空,且无默认值)
		/// 委托维修单.Misc.物料
		/// </summary>
		/// <value></value>
		public  SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey ItemPartKey
		{
			get 
			{
				object obj = base.GetValue("ItemPart") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemPartKey==null || m_ItemPartKey.ID != key )
					m_ItemPartKey = new SV.Pub.PubBE.Item.ItemPartBE.ItemPart.EntityKey(key); 
				return m_ItemPartKey ;
			}
			set
			{	
				if (ItemPartKey==value)
					return ;
				this.SetRelation("ItemPart", null);
				m_ItemPartKey = value ;
				if (value != null) 
				{
					base.SetValue("ItemPart",value.ID);
				}
				else
					base.SetValue("ItemPart",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal ItemQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ItemQty");
				return value;
				}
				set
			{
				
								base.SetValue("ItemQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// SN号 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.SN号
		/// </summary>
		/// <value></value>
			public  System.String SN
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SN");
				return value;
				}
				set
			{
				
								base.SetValue("SN", value);
						 
			}
		}
	



		
			/// <summary>
		/// 维修方案 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.维修方案
		/// </summary>
		/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum MaintenancePlan
		{
			get
			{

				SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum.GetFromValue(base.GetValue("MaintenancePlan"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("MaintenancePlan",SV.Scm.ScmBE.EntrustedRepairDocBE.MaintenancePlanEnum.Empty.Value);
				else
					base.SetValue("MaintenancePlan",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 委托费用 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.委托费用
		/// </summary>
		/// <value></value>
			public  System.Decimal EntrustedAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("EntrustedAmount");
				return value;
				}
				set
			{
				
								base.SetValue("EntrustedAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 委托费用备注 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.委托费用备注
		/// </summary>
		/// <value></value>
			public  System.String EntrustedAmountRemark
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EntrustedAmountRemark");
				return value;
				}
				set
			{
				
								base.SetValue("EntrustedAmountRemark", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实测故障 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.实测故障
		/// </summary>
		/// <value></value>
			public  System.String MeasuredFault
		{
			get
			{
				System.String value  = (System.String)base.GetValue("MeasuredFault");
				return value;
				}
				set
			{
				
								base.SetValue("MeasuredFault", value);
						 
			}
		}
	



		
			/// <summary>
		/// 服务方式 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.服务方式
		/// </summary>
		/// <value></value>
			public  System.String MaintenanceMethod
		{
			get
			{
				System.String value  = (System.String)base.GetValue("MaintenanceMethod");
				return value;
				}
				set
			{
				
								base.SetValue("MaintenanceMethod", value);
						 
			}
		}
	



		
			/// <summary>
		/// 维修完成 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.维修完成
		/// </summary>
		/// <value></value>
			public  System.Boolean IsCompleteRepair
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsCompleteRepair");
				return value;
				}
				set
			{
				
								base.SetValue("IsCompleteRepair", value);
						 
			}
		}
	



		
			/// <summary>
		/// 满意度 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.满意度
		/// </summary>
		/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum Satisfaction
		{
			get
			{

				SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum.GetFromValue(base.GetValue("Satisfaction"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Satisfaction",SV.Scm.ScmBE.EntrustedRepairDocBE.SatisfactionEnum.Empty.Value);
				else
					base.SetValue("Satisfaction",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 已支付 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.已支付
		/// </summary>
		/// <value></value>
			public  System.Boolean IsPay
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsPay");
				return value;
				}
				set
			{
				
								base.SetValue("IsPay", value);
						 
			}
		}
	



		
			/// <summary>
		/// 支付金额 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.支付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal PayAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PayAmount");
				return value;
				}
				set
			{
				
								base.SetValue("PayAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 撤销支付 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.撤销支付
		/// </summary>
		/// <value></value>
			public  System.Boolean IsRefund
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsRefund");
				return value;
				}
				set
			{
				
								base.SetValue("IsRefund", value);
						 
			}
		}
	



		
			/// <summary>
		/// 撤销金额 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.撤销金额
		/// </summary>
		/// <value></value>
			public  System.Decimal RefundAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("RefundAmount");
				return value;
				}
				set
			{
				
								base.SetValue("RefundAmount", value);
						 
			}
		}
	



		
		private SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo m_SrcDocInfo ;
			/// <summary>
		/// 来源单据信息 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.来源单据信息
		/// </summary>
		/// <value></value>
			public  SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo SrcDocInfo
		{
			get
			{
				if (m_SrcDocInfo == null )
					m_SrcDocInfo = new SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo(this, "SrcDocInfo");
				return m_SrcDocInfo;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_SrcDocInfo == null)
					this.m_SrcDocInfo = new SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo(this,"SrcDocInfo");
								this.m_SrcDocInfo.SrcDocType = value.SrcDocType ;
												this.m_SrcDocInfo.SrcDocNo = value.SrcDocNo ;
												this.m_SrcDocInfo.SrcDocID = value.SrcDocID ;
												this.m_SrcDocInfo.SrcDocLineNo = value.SrcDocLineNo ;
												this.m_SrcDocInfo.SrcDocLineID = value.SrcDocLineID ;
												this.m_SrcDocInfo.SrcDocSubLineNo = value.SrcDocSubLineNo ;
												this.m_SrcDocInfo.SrcDocSubLineID = value.SrcDocSubLineID ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 单据状态 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.单据状态
		/// </summary>
		/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum DocState
		{
			get
			{

				SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum.GetFromValue(base.GetValue("DocState"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DocState",SV.Scm.ScmBE.EntrustedRepairDocBE.DocStateEnum.Empty.Value);
				else
					base.SetValue("DocState",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 当前节点 (该属性可为空,但有默认值)
		/// 委托维修单.Misc.当前节点
		/// </summary>
		/// <value></value>
			public  SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum CurrentNode
		{
			get
			{

				SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum value  = SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum.GetFromValue(base.GetValue("CurrentNode"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("CurrentNode",SV.Scm.ScmBE.EntrustedRepairDocBE.CurrentNodeEnum.Empty.Value);
				else
					base.SetValue("CurrentNode",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 委托内容 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.委托内容
		/// </summary>
		/// <value></value>
			public  System.String EntrustmentConten
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EntrustmentConten");
				return value;
				}
				set
			{
				
								base.SetValue("EntrustmentConten", value);
						 
			}
		}
	



		
			/// <summary>
		/// 终止原因 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.终止原因
		/// </summary>
		/// <value></value>
			public  System.String TerminationReason
		{
			get
			{
				System.String value  = (System.String)base.GetValue("TerminationReason");
				return value;
				}
				set
			{
				
								base.SetValue("TerminationReason", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics.EntityList m_EntrustedRepairLogistics  ;
		/// <summary>
		/// 物流信息 (该属性可为空,且无默认值)
		/// 委托维修单.Misc.物流信息
		/// </summary>
		/// <value></value>
		public  SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics.EntityList EntrustedRepairLogistics
		{
			get
			{
				if (m_EntrustedRepairLogistics == null)
					m_EntrustedRepairLogistics = new SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics.EntityList("EntrustedRepairDoc",this,"EntrustedRepairLogistics",(IList)this.GetRelation("EntrustedRepairLogistics"));
				else
					m_EntrustedRepairLogistics.InnerList = (IList)this.GetRelation("EntrustedRepairLogistics");
				return m_EntrustedRepairLogistics;
			}
		}
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SVDocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SVDocType　{ get { return EntityRes.GetResource("SVDocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BeEntrustedSite")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BeEntrustedSite　{ get { return EntityRes.GetResource("BeEntrustedSite");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SatisfactionRemark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SatisfactionRemark　{ get { return EntityRes.GetResource("SatisfactionRemark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerName　{ get { return EntityRes.GetResource("CustomerName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerPhone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerPhone　{ get { return EntityRes.GetResource("CustomerPhone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerProvince")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerProvince　{ get { return EntityRes.GetResource("CustomerProvince");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerCity")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerCity　{ get { return EntityRes.GetResource("CustomerCity");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerDistrict")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerDistrict　{ get { return EntityRes.GetResource("CustomerDistrict");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerAdd")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerAdd　{ get { return EntityRes.GetResource("CustomerAdd");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FaultDescription")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FaultDescription　{ get { return EntityRes.GetResource("FaultDescription");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemPart")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemPart　{ get { return EntityRes.GetResource("ItemPart");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemQty　{ get { return EntityRes.GetResource("ItemQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SN")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SN　{ get { return EntityRes.GetResource("SN");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MaintenancePlan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MaintenancePlan　{ get { return EntityRes.GetResource("MaintenancePlan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EntrustedAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EntrustedAmount　{ get { return EntityRes.GetResource("EntrustedAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EntrustedAmountRemark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EntrustedAmountRemark　{ get { return EntityRes.GetResource("EntrustedAmountRemark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MeasuredFault")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MeasuredFault　{ get { return EntityRes.GetResource("MeasuredFault");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("MaintenanceMethod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_MaintenanceMethod　{ get { return EntityRes.GetResource("MaintenanceMethod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsCompleteRepair")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsCompleteRepair　{ get { return EntityRes.GetResource("IsCompleteRepair");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Satisfaction")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Satisfaction　{ get { return EntityRes.GetResource("Satisfaction");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsPay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsPay　{ get { return EntityRes.GetResource("IsPay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayAmount　{ get { return EntityRes.GetResource("PayAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsRefund")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsRefund　{ get { return EntityRes.GetResource("IsRefund");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RefundAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RefundAmount　{ get { return EntityRes.GetResource("RefundAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EntrustedRepairLogistics")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EntrustedRepairLogistics　{ get { return EntityRes.GetResource("EntrustedRepairLogistics");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocInfo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocInfo　{ get { return EntityRes.GetResource("SrcDocInfo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocState　{ get { return EntityRes.GetResource("DocState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CurrentNode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CurrentNode　{ get { return EntityRes.GetResource("CurrentNode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EntrustmentConten")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EntrustmentConten　{ get { return EntityRes.GetResource("EntrustmentConten");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TerminationReason")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TerminationReason　{ get { return EntityRes.GetResource("TerminationReason");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "EntrustedRepairDoc";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc";　}　}
		
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string SVDocType　{ get { return "SVDocType";　}　}
				
			/// <summary>
			/// 属性: 受托站点 的名称
			/// </summary>
			public static string BeEntrustedSite　{ get { return "BeEntrustedSite";　}　}
				
			/// <summary>
			/// 属性: 满意度备注 的名称
			/// </summary>
			public static string SatisfactionRemark　{ get { return "SatisfactionRemark";　}　}
				
			/// <summary>
			/// 属性: 顾客姓名 的名称
			/// </summary>
			public static string CustomerName　{ get { return "CustomerName";　}　}
				
			/// <summary>
			/// 属性: 顾客手机 的名称
			/// </summary>
			public static string CustomerPhone　{ get { return "CustomerPhone";　}　}
				
			/// <summary>
			/// 属性: 顾客地址省 的名称
			/// </summary>
			public static string CustomerProvince　{ get { return "CustomerProvince";　}　}
				
			/// <summary>
			/// 属性: 顾客地址市 的名称
			/// </summary>
			public static string CustomerCity　{ get { return "CustomerCity";　}　}
				
			/// <summary>
			/// 属性: 顾客地址区 的名称
			/// </summary>
			public static string CustomerDistrict　{ get { return "CustomerDistrict";　}　}
				
			/// <summary>
			/// 属性: 顾客地址 的名称
			/// </summary>
			public static string CustomerAdd　{ get { return "CustomerAdd";　}　}
				
			/// <summary>
			/// 属性: 故障信息 的名称
			/// </summary>
			public static string FaultDescription　{ get { return "FaultDescription";　}　}
				
			/// <summary>
			/// 属性: 物料 的名称
			/// </summary>
			public static string ItemPart　{ get { return "ItemPart";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string ItemQty　{ get { return "ItemQty";　}　}
				
			/// <summary>
			/// 属性: SN号 的名称
			/// </summary>
			public static string SN　{ get { return "SN";　}　}
				
			/// <summary>
			/// 属性: 维修方案 的名称
			/// </summary>
			public static string MaintenancePlan　{ get { return "MaintenancePlan";　}　}
				
			/// <summary>
			/// 属性: 委托费用 的名称
			/// </summary>
			public static string EntrustedAmount　{ get { return "EntrustedAmount";　}　}
				
			/// <summary>
			/// 属性: 委托费用备注 的名称
			/// </summary>
			public static string EntrustedAmountRemark　{ get { return "EntrustedAmountRemark";　}　}
				
			/// <summary>
			/// 属性: 实测故障 的名称
			/// </summary>
			public static string MeasuredFault　{ get { return "MeasuredFault";　}　}
				
			/// <summary>
			/// 属性: 服务方式 的名称
			/// </summary>
			public static string MaintenanceMethod　{ get { return "MaintenanceMethod";　}　}
				
			/// <summary>
			/// 属性: 维修完成 的名称
			/// </summary>
			public static string IsCompleteRepair　{ get { return "IsCompleteRepair";　}　}
				
			/// <summary>
			/// 属性: 满意度 的名称
			/// </summary>
			public static string Satisfaction　{ get { return "Satisfaction";　}　}
				
			/// <summary>
			/// 属性: 已支付 的名称
			/// </summary>
			public static string IsPay　{ get { return "IsPay";　}　}
				
			/// <summary>
			/// 属性: 支付金额 的名称
			/// </summary>
			public static string PayAmount　{ get { return "PayAmount";　}　}
				
			/// <summary>
			/// 属性: 撤销支付 的名称
			/// </summary>
			public static string IsRefund　{ get { return "IsRefund";　}　}
				
			/// <summary>
			/// 属性: 撤销金额 的名称
			/// </summary>
			public static string RefundAmount　{ get { return "RefundAmount";　}　}
				
			/// <summary>
			/// 属性: 物流信息 的名称
			/// </summary>
			public static string EntrustedRepairLogistics　{ get { return "EntrustedRepairLogistics";　}　}
				
			/// <summary>
			/// 属性类型属性: SrcDocInfo 的名称
			/// </summary>
			public static string SrcDocInfo { get { return "SrcDocInfo";　}　}
			/// <summary>
			/// 属性类型属性: SrcDocInfo 的类型全名
			/// </summary>
			public static string SrcDocInfo_TypeFullName { get { return "SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocType的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocType { get { return "SrcDocInfo.SrcDocType";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocNo的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocNo { get { return "SrcDocInfo.SrcDocNo";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocID的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocID { get { return "SrcDocInfo.SrcDocID";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocLineNo的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocLineNo { get { return "SrcDocInfo.SrcDocLineNo";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocLineID的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocLineID { get { return "SrcDocInfo.SrcDocLineID";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocSubLineNo的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocSubLineNo { get { return "SrcDocInfo.SrcDocSubLineNo";　}　}
			/// <summary>
			/// 属性类型属性展开:SrcDocInfo.SrcDocSubLineID的名称
			/// </summary>
			public static string SrcDocInfo_SrcDocSubLineID { get { return "SrcDocInfo.SrcDocSubLineID";　}　}
				
			/// <summary>
			/// 属性: 单据状态 的名称
			/// </summary>
			public static string DocState　{ get { return "DocState";　}　}
				
			/// <summary>
			/// 属性: 当前节点 的名称
			/// </summary>
			public static string CurrentNode　{ get { return "CurrentNode";　}　}
				
			/// <summary>
			/// 属性: 委托内容 的名称
			/// </summary>
			public static string EntrustmentConten　{ get { return "EntrustmentConten";　}　}
				
			/// <summary>
			/// 属性: 终止原因 的名称
			/// </summary>
			public static string TerminationReason　{ get { return "TerminationReason";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																				
				if (attrName.StartsWith("SrcDocInfo."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(SrcDocInfo_TypeFullName, attrName);
										
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }
        

        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("DocNo","DocNo");
			this.exdMultiLangAttrs.Add("BusinessDate","BusinessDate");
			this.exdMultiLangAttrs.Add("Version","Version");
			this.exdMultiLangAttrs.Add("PrintAmount","PrintAmount");
			this.exdMultiLangAttrs.Add("LatestPrintedDate","LatestPrintedDate");
			this.exdMultiLangAttrs.Add("Cancel.Canceled","Cancel_Canceled");
			this.exdMultiLangAttrs.Add("Cancel.CancelDate","Cancel_CancelDate");
			this.exdMultiLangAttrs.Add("Cancel.CancelReason","Cancel_CancelReason");
			this.exdMultiLangAttrs.Add("Cancel.CancelUser","Cancel_CancelUser");
			this.exdMultiLangAttrs.Add("WorkFlowID","WorkFlowID");
			this.exdMultiLangAttrs.Add("StateMachineID","StateMachineID");
			this.exdMultiLangAttrs.Add("HoldReason","HoldReason");
			this.exdMultiLangAttrs.Add("HoldUser","HoldUser");
			this.exdMultiLangAttrs.Add("HoldDate","HoldDate");
			this.exdMultiLangAttrs.Add("ReleaseReason","ReleaseReason");
			this.exdMultiLangAttrs.Add("ReleaseUser","ReleaseUser");
			this.exdMultiLangAttrs.Add("ReleaseDate","ReleaseDate");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg1","DescFlexField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg2","DescFlexField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg3","DescFlexField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg4","DescFlexField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg5","DescFlexField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg6","DescFlexField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg7","DescFlexField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg8","DescFlexField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg9","DescFlexField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg10","DescFlexField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg11","DescFlexField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg12","DescFlexField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg13","DescFlexField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg14","DescFlexField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg15","DescFlexField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg16","DescFlexField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg17","DescFlexField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg18","DescFlexField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg19","DescFlexField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg20","DescFlexField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg21","DescFlexField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg22","DescFlexField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg23","DescFlexField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg24","DescFlexField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg25","DescFlexField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg26","DescFlexField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg27","DescFlexField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg28","DescFlexField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg29","DescFlexField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg30","DescFlexField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg31","DescFlexField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg32","DescFlexField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg33","DescFlexField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg34","DescFlexField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg35","DescFlexField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg36","DescFlexField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg37","DescFlexField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg38","DescFlexField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg39","DescFlexField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg40","DescFlexField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg41","DescFlexField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg42","DescFlexField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg43","DescFlexField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg44","DescFlexField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg45","DescFlexField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg46","DescFlexField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg47","DescFlexField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg48","DescFlexField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg49","DescFlexField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg50","DescFlexField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexField.ContextValue","DescFlexField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg1","DescFlexField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg2","DescFlexField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg3","DescFlexField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg4","DescFlexField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg5","DescFlexField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg6","DescFlexField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg7","DescFlexField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg8","DescFlexField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg9","DescFlexField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg10","DescFlexField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg11","DescFlexField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg12","DescFlexField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg13","DescFlexField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg14","DescFlexField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg15","DescFlexField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg16","DescFlexField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg17","DescFlexField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg18","DescFlexField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg19","DescFlexField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg20","DescFlexField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg21","DescFlexField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg22","DescFlexField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg23","DescFlexField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg24","DescFlexField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg25","DescFlexField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg26","DescFlexField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg27","DescFlexField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg28","DescFlexField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg29","DescFlexField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg30","DescFlexField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexField.CombineName","DescFlexField_CombineName");
			this.exdMultiLangAttrs.Add("FlowInstance","FlowInstance");
			this.exdMultiLangAttrs.Add("SVDocType","SVDocType");
			this.exdMultiLangAttrs.Add("BeEntrustedSite","BeEntrustedSite");
			this.exdMultiLangAttrs.Add("SatisfactionRemark","SatisfactionRemark");
			this.exdMultiLangAttrs.Add("CustomerName","CustomerName");
			this.exdMultiLangAttrs.Add("CustomerPhone","CustomerPhone");
			this.exdMultiLangAttrs.Add("CustomerProvince","CustomerProvince");
			this.exdMultiLangAttrs.Add("CustomerCity","CustomerCity");
			this.exdMultiLangAttrs.Add("CustomerDistrict","CustomerDistrict");
			this.exdMultiLangAttrs.Add("CustomerAdd","CustomerAdd");
			this.exdMultiLangAttrs.Add("FaultDescription","FaultDescription");
			this.exdMultiLangAttrs.Add("ItemPart","ItemPart");
			this.exdMultiLangAttrs.Add("ItemQty","ItemQty");
			this.exdMultiLangAttrs.Add("SN","SN");
			this.exdMultiLangAttrs.Add("MaintenancePlan","MaintenancePlan");
			this.exdMultiLangAttrs.Add("EntrustedAmount","EntrustedAmount");
			this.exdMultiLangAttrs.Add("EntrustedAmountRemark","EntrustedAmountRemark");
			this.exdMultiLangAttrs.Add("MeasuredFault","MeasuredFault");
			this.exdMultiLangAttrs.Add("MaintenanceMethod","MaintenanceMethod");
			this.exdMultiLangAttrs.Add("IsCompleteRepair","IsCompleteRepair");
			this.exdMultiLangAttrs.Add("Satisfaction","Satisfaction");
			this.exdMultiLangAttrs.Add("IsPay","IsPay");
			this.exdMultiLangAttrs.Add("PayAmount","PayAmount");
			this.exdMultiLangAttrs.Add("IsRefund","IsRefund");
			this.exdMultiLangAttrs.Add("RefundAmount","RefundAmount");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocType","SrcDocInfo_SrcDocType");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocNo","SrcDocInfo_SrcDocNo");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocID","SrcDocInfo_SrcDocID");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocLineNo","SrcDocInfo_SrcDocLineNo");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocLineID","SrcDocInfo_SrcDocLineID");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocSubLineNo","SrcDocInfo_SrcDocSubLineNo");
			this.exdMultiLangAttrs.Add("SrcDocInfo.SrcDocSubLineID","SrcDocInfo_SrcDocSubLineID");
			this.exdMultiLangAttrs.Add("DocState","DocState");
			this.exdMultiLangAttrs.Add("CurrentNode","CurrentNode");
			this.exdMultiLangAttrs.Add("EntrustmentConten","EntrustmentConten");
			this.exdMultiLangAttrs.Add("TerminationReason","TerminationReason");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																																
																					

												

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(EntrustedRepairDocData data)
		{
		
			if (data.SVDocType == -1 && data.SVDocType_SKey!=null)
				data.SVDocType = data.SVDocType_SKey.GetEntity().ID ;
	

			if (data.BeEntrustedSite == -1 && data.BeEntrustedSite_SKey!=null)
				data.BeEntrustedSite = data.BeEntrustedSite_SKey.GetEntity().ID ;
	

			

			

			

			if (data.CustomerProvince == -1 && data.CustomerProvince_SKey!=null)
				data.CustomerProvince = data.CustomerProvince_SKey.GetEntity().ID ;
	

			if (data.CustomerCity == -1 && data.CustomerCity_SKey!=null)
				data.CustomerCity = data.CustomerCity_SKey.GetEntity().ID ;
	

			if (data.CustomerDistrict == -1 && data.CustomerDistrict_SKey!=null)
				data.CustomerDistrict = data.CustomerDistrict_SKey.GetEntity().ID ;
	

			

			

			if (data.ItemPart == -1 && data.ItemPart_SKey!=null)
				data.ItemPart = data.ItemPart_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			EntrustedRepairDocData data = dto as EntrustedRepairDocData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(EntrustedRepairDocData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(EntrustedRepairDocData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
		
			base.FromEntityData(data,dict) ;
		
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
								this.SetTypeValue("SVDocType",data.SVDocType);
		
								this.SetTypeValue("BeEntrustedSite",data.BeEntrustedSite);
		
								this.SetTypeValue("SatisfactionRemark",data.SatisfactionRemark);
		
								this.SetTypeValue("CustomerName",data.CustomerName);
		
								this.SetTypeValue("CustomerPhone",data.CustomerPhone);
		
								this.SetTypeValue("CustomerProvince",data.CustomerProvince);
		
								this.SetTypeValue("CustomerCity",data.CustomerCity);
		
								this.SetTypeValue("CustomerDistrict",data.CustomerDistrict);
		
								this.SetTypeValue("CustomerAdd",data.CustomerAdd);
		
								this.SetTypeValue("FaultDescription",data.FaultDescription);
		
								this.SetTypeValue("ItemPart",data.ItemPart);
		
								this.SetTypeValue("ItemQty",data.ItemQty);
		
								this.SetTypeValue("SN",data.SN);
		
								this.SetTypeValue("EntrustedAmount",data.EntrustedAmount);
		
								this.SetTypeValue("EntrustedAmountRemark",data.EntrustedAmountRemark);
		
								this.SetTypeValue("MeasuredFault",data.MeasuredFault);
		
								this.SetTypeValue("MaintenanceMethod",data.MaintenanceMethod);
		
								this.SetTypeValue("IsCompleteRepair",data.IsCompleteRepair);
		
								this.SetTypeValue("IsPay",data.IsPay);
		
								this.SetTypeValue("PayAmount",data.PayAmount);
		
								this.SetTypeValue("IsRefund",data.IsRefund);
		
								this.SetTypeValue("RefundAmount",data.RefundAmount);
		
								this.SrcDocInfo.FromEntityData(data.SrcDocInfo);
		
								this.SetTypeValue("EntrustmentConten",data.EntrustmentConten);
		
								this.SetTypeValue("TerminationReason",data.TerminationReason);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("MaintenancePlan",data.MaintenancePlan);
	     

					this.SetTypeValue("Satisfaction",data.Satisfaction);
	     

					if (data.EntrustedRepairLogistics != null)
			{	
				foreach(SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogisticsData obj in data.EntrustedRepairLogistics )
				{
					SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics child = dict[obj] as SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.EntrustedRepairLogistics.Remove(child);
						this.EntrustedRepairLogistics.DelLists.Add(child);
					}
					else
						this.EntrustedRepairLogistics.Add(child);
				}
			}
	     

					this.SetTypeValue("DocState",data.DocState);
	     

					this.SetTypeValue("CurrentNode",data.CurrentNode);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new EntrustedRepairDocData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public EntrustedRepairDocData ToEntityData(EntrustedRepairDocData data, IDictionary dict){
			if (data == null)
				data = new EntrustedRepairDocData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("SVDocType");
				if (obj != null)
					data.SVDocType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BeEntrustedSite");
				if (obj != null)
					data.BeEntrustedSite=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SatisfactionRemark");
				if (obj != null)
					data.SatisfactionRemark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerName");
				if (obj != null)
					data.CustomerName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerPhone");
				if (obj != null)
					data.CustomerPhone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerProvince");
				if (obj != null)
					data.CustomerProvince=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerCity");
				if (obj != null)
					data.CustomerCity=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerDistrict");
				if (obj != null)
					data.CustomerDistrict=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerAdd");
				if (obj != null)
					data.CustomerAdd=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FaultDescription");
				if (obj != null)
					data.FaultDescription=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemPart");
				if (obj != null)
					data.ItemPart=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemQty");
				if (obj != null)
					data.ItemQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SN");
				if (obj != null)
					data.SN=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EntrustedAmount");
				if (obj != null)
					data.EntrustedAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EntrustedAmountRemark");
				if (obj != null)
					data.EntrustedAmountRemark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MeasuredFault");
				if (obj != null)
					data.MeasuredFault=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("MaintenanceMethod");
				if (obj != null)
					data.MaintenanceMethod=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsCompleteRepair");
				if (obj != null)
					data.IsCompleteRepair=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsPay");
				if (obj != null)
					data.IsPay=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayAmount");
				if (obj != null)
					data.PayAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsRefund");
				if (obj != null)
					data.IsRefund=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RefundAmount");
				if (obj != null)
					data.RefundAmount=(System.Decimal)obj;
			}
	     
	    
			if (this.SrcDocInfo != null)
			{
				data.SrcDocInfo=this.SrcDocInfo.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("EntrustmentConten");
				if (obj != null)
					data.EntrustmentConten=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TerminationReason");
				if (obj != null)
					data.TerminationReason=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("MaintenancePlan");
				if (obj != null)
					data.MaintenancePlan=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("Satisfaction");
				if (obj != null)
					data.Satisfaction=System.Int32.Parse(obj.ToString());
			}
	
			if (this.EntrustedRepairLogistics != null)
			{	
				List<SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogisticsData> listEntrustedRepairLogistics = new List<SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogisticsData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics obj in this.EntrustedRepairLogistics ){
					if (obj == null)
						continue;
					SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogisticsData old = dict["SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogistics"+obj.ID.ToString()] as SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairLogisticsData;
					listEntrustedRepairLogistics.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.EntrustedRepairLogistics = listEntrustedRepairLogistics;
			}	
			{
				object obj =this.GetValue("DocState");
				if (obj != null)
					data.DocState=System.Int32.Parse(obj.ToString());
			}
	
			{
				object obj =this.GetValue("CurrentNode");
				if (obj != null)
					data.CurrentNode=System.Int32.Parse(obj.ToString());
			}
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
		//L类档案的组织相关检查.
		UFIDA.U9.Base.Util.LTypeOrgAttributeValidator.Validate(this);
        

























			
			//调用SV.Pub.PubBE.Pub.PubDTO.DocSrcInfo属性类型的内置校验方法.
			this.SrcDocInfo.OnValidate() ;
	




			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (Convert.ToInt64(base.GetValue("BeEntrustedSite")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException BeEntrustedSite_Exception = new UFSoft.UBF.Business.AttributeInValidException("SV.Scm.ScmBE.EntrustedRepairDocBE.EntrustedRepairDoc","BeEntrustedSite","dfa3ceda-a9b8-49d0-a5bb-66e2f2548c97");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					BeEntrustedSite_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(BeEntrustedSite_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}