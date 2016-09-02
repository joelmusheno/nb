using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using nb;
using nb.Controllers;
using nb.Infrastructure;
using nb.Models;

namespace nb.Tests
{
	[TestFixture]
	public class NeedRepositoryTest
	{
		[Test]
		public void CanVarUpNewRepo()
		{
			var repo = new InMemoryRepository<Need>();
			Assert.IsNotNull(repo);
		}

		[Test]
		public void ShouldThrowException()
		{
			InMemoryRepository<Need> repo = null;
			repo.Save(null);

			Assert.IsTrue(true);
		}
	}
}
