using System;
namespace SP.Model
{
	/// <summary>
	/// news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class news
	{
		public news()
		{}
		#region Model
		private int _nid;
		private string _title;
		private int? _tid;
		private string _memo;
		private DateTime? _atime;
		/// <summary>
		/// 编号
		/// </summary>
		public int nid
		{
			set{ _nid=value;}
			get{return _nid;}
		}
		/// <summary>
		/// 新闻标题
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 所属类别
		/// </summary>
		public int? tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 新闻内容
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? atime
		{
			set{ _atime=value;}
			get{return _atime;}
		}
		#endregion Model

	}
}

