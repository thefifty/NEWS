﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Domain;

namespace Commands.News
{
	public interface ICreateNewsCommand
	{
		NewInfo Info { get; set; }
		IEnumerable<Guid> Scopes { get; set; }
		bool Authenticated { get; set; }
	}
	public abstract class CreateNewsBaseCommand : Command<CreateNewsResponse>, ICreateNewsCommand
	{
		public NewInfo Info { get; set; }
		public string Image { get; set; }
		public string Text { get; set; }
		public bool Authenticated { get; set; }
		public IEnumerable<Guid> Scopes { get; set; }
	}

	public class CreateNewsByTopImageContentCommand : CreateNewsBaseCommand
	{
	}

	public class CreateNewsByBottomImageContentCommand : CreateNewsBaseCommand
	{
	}

	public class CreateNewsByTopBottomImageContentCommand : Command<CreateNewsResponse>, ICreateNewsCommand
	{
		public NewInfo Info { get; set; }
		public string Image { get; set; }
		public string BottomImage { get; set; }
		public string Text { get; set; }
		public IEnumerable<Guid> Scopes { get; set; }
		public bool Authenticated { get; set; }
	}


	public class NewInfo
	{
		public string Title { get; set; }
		public string Summery { get; set; }
		public string TitleImage { get; set; }
		public DateTime? ExpirationTime { get; set; }
		public int ExpireDuration { get; set; }
		public Guid ScopeId  { get; set; }

	}



	public class FreeNewsContentCommand : Command<CreateNewsResponse>, ICreateNewsCommand
	{
		public NewInfo Info { get; set; }
		public string Content { get; set; }
		public IEnumerable<string> Files { get; set; }
		public IEnumerable<Guid> Scopes { get; set; }
		public bool Authenticated { get; set; }
	}
	public class CreateNewsResponse
	{
		public long NewsId { get; set; }
	}
}
