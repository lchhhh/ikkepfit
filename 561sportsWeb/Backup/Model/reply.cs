using System;
namespace SP.Model
{
	/// <summary>
	/// reply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class reply
	{
		public reply()
		{}
		#region Model
		private int _rid;
		private int? _aid;
		private string _memo;
		private string _lname;
		private DateTime? _atime;
		/// <summary>
		/// 编号
		/// </summary>
		public int rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 所属帖子
		/// </summary>
		public int? aid
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 回复人
		/// </summary>
		public string lname
		{
			set{ _lname=value;}
			get{return _lname;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? atime
		{
			set{ _atime=value;}
			get{return _atime;}
		}
		#endregion Model

	}
}

