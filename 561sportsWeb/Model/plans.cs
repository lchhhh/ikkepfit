﻿using System;
namespace SP.Model
{
	/// <summary>
	/// plans:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class plans
	{
		public plans()
		{}
		#region Model
		private int _pid;
		private string _title;
        private int? _tid;
		private string _memo;
        private string _remarks;
		private DateTime? _atime;
		/// <summary>
		/// 编号
		/// </summary>
		public int pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 标题
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
            set { _tid = value; }
            get { return _tid; }
        }
		/// <summary>
		/// 内容
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}

        public string remarks
        { set{_remarks=value;}
        get{return _remarks;}
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

