using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using AdapterPattern.Library;

namespace AdapterPattern.Model
{
	public class PatternRenderer
	{
		private readonly IDataPatternRendererAdapter _renderer;

		public PatternRenderer() : this (new DataPatternRendererAdapter())
		{
		}

		private PatternRenderer(IDataPatternRendererAdapter renderer)
		{
			_renderer = renderer;
		}

		public string ListPatterns(IEnumerable<Pattern> patterns)
		{
			return _renderer.ListPatterns(patterns);
		}
	}

	public interface IDataPatternRendererAdapter
	{
		string ListPatterns(IEnumerable<Pattern> patterns);
	}

	public class DataPatternRendererAdapter : IDataPatternRendererAdapter
	{
		private DataRenderer _dataRenderer;
		public string ListPatterns(IEnumerable<Pattern> patterns)
		{
			var adapter = new PatternCollectionDbAdapter(patterns);
			_dataRenderer = new DataRenderer(adapter);

			var writer = new StringWriter();
			_dataRenderer.Render(writer);

			return writer.ToString();
		}

		private class PatternCollectionDbAdapter : IDbDataAdapter
		{
			private readonly IEnumerable<Pattern> _patterns;

			public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns)
			{
				_patterns = patterns;
			}

			public int Fill(DataSet dataSet)
			{
				var dataTable = new DataTable();
				dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
				dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
				dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

				foreach (var pattern in _patterns)
				{
					var row = dataTable.NewRow();
					row[0] = pattern.Id;
					row[1] = pattern.Name;
					row[2] = pattern.Description;
					dataTable.Rows.Add(row);
				}

				dataSet.Tables.Add(dataTable);
				dataSet.AcceptChanges();

				return dataTable.Rows.Count;
			}

			#region NotImplemeted
			public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
			{
				throw new System.NotImplementedException();
			}

			public IDataParameter[] GetFillParameters()
			{
				throw new System.NotImplementedException();
			}

			public int Update(DataSet dataSet)
			{
				throw new System.NotImplementedException();
			}

			public MissingMappingAction MissingMappingAction { get; set; }
			public MissingSchemaAction MissingSchemaAction { get; set; }
			public ITableMappingCollection TableMappings { get; }
			public IDbCommand SelectCommand { get; set; }
			public IDbCommand InsertCommand { get; set; }
			public IDbCommand UpdateCommand { get; set; }
			public IDbCommand DeleteCommand { get; set; }
			#endregion
		}
	}
}