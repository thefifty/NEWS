﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Commands.News
{
	public class DeleteNewCommand : Command
	{
		public long NewsId { get; set; }
	}
}