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
        private string _rmemo;
		private string _lname;
		private DateTime? _rtime;
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
        public string rmemo
		{
            set { _rmemo = value; }
            get { return _rmemo; }
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
		public DateTime? rtime
		{
			set{ _rtime=value;}
			get{return _rtime;}
		}
		#endregion Model

	}
}

