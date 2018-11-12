﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由WEF.ModelGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null生成;时间 2018-11-12 14:37:16.391
//     运行时版本:4.0.30319.42000
//     不建议手动更改此代码，如有需要请自行扩展partial类
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Runtime.Serialization;
using WEF;
using WEF.Common;
using WEF.Section;
using System.Collections.Generic;

namespace WebBaseFrame.Models
{

	/// <summary>
	/// 实体类Member
	/// </summary>
	[Serializable, DataContract]
	public partial class Member : Entity 
	{
		private static string m_tableName;
		public Member():base("Member") {m_tableName="Member";}
		public Member(string tableName):base(tableName) { m_tableName=tableName;}

		#region Model
		private int _ID;
		private int _RoleID;
		private string _UserName;
		private string _Password;
		private string _PwdNotMD5;
		private string _RealName;
		private int? _Status;
		private string _IDcard;
		private string _Mobile;
		private string _Email;
		private string _Avatar;
		private string _Address;
		private string _QQ;
		private string _WeiXin;
		private DateTime? _CreateDate;
		private int? _CreateUserID;
		private DateTime? _LastUpdateDate;
		private int? _LastUpdateUserID;
		private bool _IsDeleted;
		/// <summary>
		/// ID 
		/// </summary>
		[DataMember]
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// RoleID 
		/// </summary>
		[DataMember]
		public int RoleID
		{
			get{ return _RoleID; }
			set
			{
				this.OnPropertyValueChange(_.RoleID,_RoleID,value);
				this._RoleID=value;
			}
		}
		/// <summary>
		/// UserName 
		/// </summary>
		[DataMember]
		public string UserName
		{
			get{ return _UserName; }
			set
			{
				this.OnPropertyValueChange(_.UserName,_UserName,value);
				this._UserName=value;
			}
		}
		/// <summary>
		/// Password 
		/// </summary>
		[DataMember]
		public string Password
		{
			get{ return _Password; }
			set
			{
				this.OnPropertyValueChange(_.Password,_Password,value);
				this._Password=value;
			}
		}
		/// <summary>
		/// PwdNotMD5 
		/// </summary>
		[DataMember]
		public string PwdNotMD5
		{
			get{ return _PwdNotMD5; }
			set
			{
				this.OnPropertyValueChange(_.PwdNotMD5,_PwdNotMD5,value);
				this._PwdNotMD5=value;
			}
		}
		/// <summary>
		/// RealName 
		/// </summary>
		[DataMember]
		public string RealName
		{
			get{ return _RealName; }
			set
			{
				this.OnPropertyValueChange(_.RealName,_RealName,value);
				this._RealName=value;
			}
		}
		/// <summary>
		/// Status 
		/// </summary>
		[DataMember]
		public int? Status
		{
			get{ return _Status; }
			set
			{
				this.OnPropertyValueChange(_.Status,_Status,value);
				this._Status=value;
			}
		}
		/// <summary>
		/// IDcard 
		/// </summary>
		[DataMember]
		public string IDcard
		{
			get{ return _IDcard; }
			set
			{
				this.OnPropertyValueChange(_.IDcard,_IDcard,value);
				this._IDcard=value;
			}
		}
		/// <summary>
		/// Mobile 
		/// </summary>
		[DataMember]
		public string Mobile
		{
			get{ return _Mobile; }
			set
			{
				this.OnPropertyValueChange(_.Mobile,_Mobile,value);
				this._Mobile=value;
			}
		}
		/// <summary>
		/// Email 
		/// </summary>
		[DataMember]
		public string Email
		{
			get{ return _Email; }
			set
			{
				this.OnPropertyValueChange(_.Email,_Email,value);
				this._Email=value;
			}
		}
		/// <summary>
		/// Avatar 
		/// </summary>
		[DataMember]
		public string Avatar
		{
			get{ return _Avatar; }
			set
			{
				this.OnPropertyValueChange(_.Avatar,_Avatar,value);
				this._Avatar=value;
			}
		}
		/// <summary>
		/// Address 
		/// </summary>
		[DataMember]
		public string Address
		{
			get{ return _Address; }
			set
			{
				this.OnPropertyValueChange(_.Address,_Address,value);
				this._Address=value;
			}
		}
		/// <summary>
		/// QQ 
		/// </summary>
		[DataMember]
		public string QQ
		{
			get{ return _QQ; }
			set
			{
				this.OnPropertyValueChange(_.QQ,_QQ,value);
				this._QQ=value;
			}
		}
		/// <summary>
		/// WeiXin 
		/// </summary>
		[DataMember]
		public string WeiXin
		{
			get{ return _WeiXin; }
			set
			{
				this.OnPropertyValueChange(_.WeiXin,_WeiXin,value);
				this._WeiXin=value;
			}
		}
		/// <summary>
		/// CreateDate 
		/// </summary>
		[DataMember]
		public DateTime? CreateDate
		{
			get{ return _CreateDate; }
			set
			{
				this.OnPropertyValueChange(_.CreateDate,_CreateDate,value);
				this._CreateDate=value;
			}
		}
		/// <summary>
		/// CreateUserID 
		/// </summary>
		[DataMember]
		public int? CreateUserID
		{
			get{ return _CreateUserID; }
			set
			{
				this.OnPropertyValueChange(_.CreateUserID,_CreateUserID,value);
				this._CreateUserID=value;
			}
		}
		/// <summary>
		/// LastUpdateDate 
		/// </summary>
		[DataMember]
		public DateTime? LastUpdateDate
		{
			get{ return _LastUpdateDate; }
			set
			{
				this.OnPropertyValueChange(_.LastUpdateDate,_LastUpdateDate,value);
				this._LastUpdateDate=value;
			}
		}
		/// <summary>
		/// LastUpdateUserID 
		/// </summary>
		[DataMember]
		public int? LastUpdateUserID
		{
			get{ return _LastUpdateUserID; }
			set
			{
				this.OnPropertyValueChange(_.LastUpdateUserID,_LastUpdateUserID,value);
				this._LastUpdateUserID=value;
			}
		}
		/// <summary>
		/// IsDeleted 
		/// </summary>
		[DataMember]
		public bool IsDeleted
		{
			get{ return _IsDeleted; }
			set
			{
				this.OnPropertyValueChange(_.IsDeleted,_IsDeleted,value);
				this._IsDeleted=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.RoleID,
				_.UserName,
				_.Password,
				_.PwdNotMD5,
				_.RealName,
				_.Status,
				_.IDcard,
				_.Mobile,
				_.Email,
				_.Avatar,
				_.Address,
				_.QQ,
				_.WeiXin,
				_.CreateDate,
				_.CreateUserID,
				_.LastUpdateDate,
				_.LastUpdateUserID,
				_.IsDeleted};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._RoleID,
				this._UserName,
				this._Password,
				this._PwdNotMD5,
				this._RealName,
				this._Status,
				this._IDcard,
				this._Mobile,
				this._Email,
				this._Avatar,
				this._Address,
				this._QQ,
				this._WeiXin,
				this._CreateDate,
				this._CreateUserID,
				this._LastUpdateDate,
				this._LastUpdateUserID,
				this._IsDeleted};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// Member 
			/// </summary>
			public readonly static Field All = new Field("*",m_tableName);
			/// <summary>
			/// ID 
			/// </summary>
			public readonly static Field ID = new Field("ID",m_tableName,"ID");
			/// <summary>
			/// RoleID 
			/// </summary>
			public readonly static Field RoleID = new Field("RoleID",m_tableName,"RoleID");
			/// <summary>
			/// UserName 
			/// </summary>
			public readonly static Field UserName = new Field("UserName",m_tableName,"UserName");
			/// <summary>
			/// Password 
			/// </summary>
			public readonly static Field Password = new Field("Password",m_tableName,"Password");
			/// <summary>
			/// PwdNotMD5 
			/// </summary>
			public readonly static Field PwdNotMD5 = new Field("PwdNotMD5",m_tableName,"PwdNotMD5");
			/// <summary>
			/// RealName 
			/// </summary>
			public readonly static Field RealName = new Field("RealName",m_tableName,"RealName");
			/// <summary>
			/// Status 
			/// </summary>
			public readonly static Field Status = new Field("Status",m_tableName,"Status");
			/// <summary>
			/// IDcard 
			/// </summary>
			public readonly static Field IDcard = new Field("IDcard",m_tableName,"IDcard");
			/// <summary>
			/// Mobile 
			/// </summary>
			public readonly static Field Mobile = new Field("Mobile",m_tableName,"Mobile");
			/// <summary>
			/// Email 
			/// </summary>
			public readonly static Field Email = new Field("Email",m_tableName,"Email");
			/// <summary>
			/// Avatar 
			/// </summary>
			public readonly static Field Avatar = new Field("Avatar",m_tableName,"Avatar");
			/// <summary>
			/// Address 
			/// </summary>
			public readonly static Field Address = new Field("Address",m_tableName,"Address");
			/// <summary>
			/// QQ 
			/// </summary>
			public readonly static Field QQ = new Field("QQ",m_tableName,"QQ");
			/// <summary>
			/// WeiXin 
			/// </summary>
			public readonly static Field WeiXin = new Field("WeiXin",m_tableName,"WeiXin");
			/// <summary>
			/// CreateDate 
			/// </summary>
			public readonly static Field CreateDate = new Field("CreateDate",m_tableName,"CreateDate");
			/// <summary>
			/// CreateUserID 
			/// </summary>
			public readonly static Field CreateUserID = new Field("CreateUserID",m_tableName,"CreateUserID");
			/// <summary>
			/// LastUpdateDate 
			/// </summary>
			public readonly static Field LastUpdateDate = new Field("LastUpdateDate",m_tableName,"LastUpdateDate");
			/// <summary>
			/// LastUpdateUserID 
			/// </summary>
			public readonly static Field LastUpdateUserID = new Field("LastUpdateUserID",m_tableName,"LastUpdateUserID");
			/// <summary>
			/// IsDeleted 
			/// </summary>
			public readonly static Field IsDeleted = new Field("IsDeleted",m_tableName,"IsDeleted");
		}
		#endregion


	}
	/// <summary>
	/// 实体类Member操作类
	/// </summary>
	public partial class MemberRepository
	{
		DBContext db;
		/// <summary>
		/// 当前实体查询上下文
		/// </summary>
		public ISearch<Member> Search(string tableName="")
		{
			if (string.IsNullOrEmpty(tableName))
			{
				tableName="Member";
			}
				return db.Search<Member>(tableName);
		}
		/// <summary>
		/// 当前实体查询上下文
		/// </summary>
		public ISearch<Member> Search(Member entity)
		{
				return db.Search<Member>(entity);
		}
		/// <summary>
		/// 构造方法
		/// </summary>
		public MemberRepository()
		{
			db = new DBContext();
		}
		/// <summary>
		/// 构造方法
		/// <param name="connStrName">连接字符串中的名称</param>
		/// </summary>
		public MemberRepository(string connStrName)
		{
			db = new DBContext(connStrName);
		}
		/// <summary>
		/// 当前db操作上下文
		/// </summary>
		public DBContext DBContext
		{
			get
			{
				return db;
			}
		}
		/// <summary>
		/// 获取实体
		/// <param name="pageIndex">分页第几页</param>
		/// <param name="pageSize">分页一页取值</param>
		/// </summary>
		public Member GetMember(int id)
		{
			return Search().Where(b => b.ID == id).First();
		}
		/// <summary>
		/// 获取列表
		/// <param name="pageIndex">分页第几页</param>
		/// <param name="pageSize">分页一页取值</param>
		/// </summary>
		public List<Member> GetList(int pageIndex, int pageSize)
		{
			return this.Search().Page(pageIndex, pageSize).ToList();
		}
		/// <summary>
		/// 获取列表
		/// <param name="tableName">表名</param>
		/// <param name="pageIndex">分页第几页</param>
		/// <param name="pageSize">分页一页取值</param>
		/// </summary>
		public List<Member> GetList(string tableName, int pageIndex=1, int pageSize=12)
		{
			return this.Search(tableName).Page(pageIndex, pageSize).ToList();
		}
		/// <summary>
		/// 添加实体
		/// <param name="obj">传进的实体</param>
		/// </summary>
		public int Insert(Member obj)
		{
			return db.Insert(obj);
		}
		/// <summary>
		/// 更新实体
		/// <param name="obj">传进的实体</param>
		/// </summary>
		public int Update(Member obj)
		{
			return db.Update(obj);
		}
		/// <summary>
		/// 删除实体
		/// <param name="obj">传进的实体</param>
		/// </summary>
		public int Delete(Member obj)
		{
			return db.Delete(obj);
		}
		/// <summary>
		/// 删除实体
		/// <param name="id">id</param>
		/// </summary>
		public int Delete(int id)
		{
			var obj = Search().Where(b => b.ID == id).First();
			return db.Delete(obj);
		}
		/// <summary>
		/// 批量删除实体
		/// <param name="obj">传进的实体列表</param>
		/// </summary>
		public int Deletes(List<Member> objs)
		{
			return db.Delete<Member>(objs);
		}
		/// <summary>
		/// 执行sql语句
		/// <param name="sql"></param>
		/// </summary>
		public SqlSection ExecuteSQL(string sql)
		{
			return db.FromSql(sql);
		}
		/// <summary>
		/// 执行存储过程
		/// <param name="sql"></param>
		/// </summary>
		public ProcSection ExcuteProc(string procName)
		{
			return db.FromProc(procName);
		}
	}

}
