using System;
namespace SP.Model
{
	/// <summary>
	/// newsType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class newsType
	{
		public newsType()
		{}
		#region Model
		private int _tid;
		private string _tname;
		/// <summary>
		/// 类别编号
		/// </summary>
		public int tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string tname
		{
			set{ _tname=value;}
			get{return _tname;}
		}
		#endregion Model

	}
}

