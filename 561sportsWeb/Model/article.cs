using System;
namespace SP.Model
{
	/// <summary>
	/// article:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class article
	{
		public article()
		{}
		#region Model
		private int _aid;
		private string _title;
		private string _memo;
		private int? _total1;
		private string _lname;
		private DateTime? _atime;
        private string _pic;
		/// <summary>
		/// 编号
		/// </summary>
		public int aid
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 主题
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 浏览次数
		/// </summary>
		public int? total1
		{
			set{ _total1=value;}
			get{return _total1;}
		}
		/// <summary>
		/// 发贴人
		/// </summary>
		public string lname
		{
			set{ _lname=value;}
			get{return _lname;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? atime
		{
			set{ _atime=value;}
			get{return _atime;}
		}
        /// <summary>
        /// 图片
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
		#endregion Model

	}
}

