using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Plugin
{

	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IForeignKeys))]

	public class PluginForeignKeys : ForeignKeys
    {
        private IMyMetaPlugin plugin;

        public PluginForeignKeys(IMyMetaPlugin plugin)
        {
            this.plugin = plugin;
		}

		override internal void LoadAll()
        {
            DataTable metaData = this.plugin.GetForeignKeys(this.Table.Database.Name, this.Table.Name);
            PopulateArray(metaData);
		}
	}
}
