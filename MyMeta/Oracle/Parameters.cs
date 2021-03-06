using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Oracle
{

	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IParameters))]

	public class OracleParameters : Parameters
	{
		public OracleParameters()
		{

		}

		override internal void LoadAll()
		{
			try
			{
				DataTable metaData = this.LoadData(OleDbSchemaGuid.Procedure_Parameters, 
					new object[]{null, this.Procedure.Database.Name, this.Procedure.Name});

				PopulateArray(metaData);
			}
			catch {}
		}
	}
}
