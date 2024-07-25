﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Queries
{
	public class GetNewsById : IQuery<NewsSimpleDto>
	{
		public long NewsId { get; set; }
	}

	public class NewsListDto : IListDto<NewsSimpleDto>
	{
		public IEnumerable<NewsSimpleDto> Items { get; set; }
	}
}
