using System;
namespace SP.Model
{
	/// <summary>
	/// members:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class members
	{
		public members()
		{}
		#region Model
		private string _lname;
		private string _pass;
		private string _mname;
		private string _sex;
		private string _tel;
		private string _mpic;
		private DateTime? _regtime;
		/// <summary>
		/// 登录名
		/// </summary>
		public string lname
		{
			set{ _lname=value;}
			get{return _lname;}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string pass
		{
			set{ _pass=value;}
			get{return _pass;}
		}
		/// <summary>
		/// 昵称
		/// </summary>
		public string mname
		{
			set{ _mname=value;}
			get{return _mname;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 联系方式
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 头像
		/// </summary>
		public string mpic
		{
			set{ _mpic=value;}
			get{return _mpic;}
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime? regtime
		{
			set{ _regtime=value;}
			get{return _regtime;}
		}
		#endregion Model

	}
}

