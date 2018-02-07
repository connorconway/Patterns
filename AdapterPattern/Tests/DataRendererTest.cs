using System;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using AdapterPattern.Library;
using NUnit.Framework;

namespace AdapterPattern.Tests
{
	[TestFixture]
	public class DataRendererTest
	{
		[Test]
		public void RenderOneRowGivenStubDataAdapter()
		{
			var myRenderer = new DataRenderer(new StudDbAdapter());
			var writer = new StringWriter();
			myRenderer.Render(writer);

			var result = writer.ToString();
			Console.Write(result);

			var lineCount = result.Count(c => c == '\n');
			Assert.AreEqual(3, lineCount);
		}

		[Test]
		[Ignore("Have not installed SQL Server Compact to create a sample.sdf database")]
		public void RenderTwoRowsGivenOleDbDataAdapter()
		{
			var adapter = new OleDbDataAdapter();
			adapter.SelectCommand = new OleDbCommand("SELECT * FROM Pattern");
			adapter.SelectCommand.Connection = new OleDbConnection();
			var renderer = new DataRenderer(adapter);
			var writer = new StringWriter();
			renderer.Render(writer);

			var result = writer.ToString();
			Console.Write(result);

			var lineCount = result.Count(c => c == '\n');
			Assert.AreEqual(4, lineCount);
		}
	}
}