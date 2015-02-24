﻿using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class RowGuidColTableUpdate : StoredProcedure
    {
        public const String Name = "RowGuidColTableUpdate";
        private Guid _RowGuidColumn;
        private String _NVarCharColumn = "";
        private Guid _PK_RowGuidColumn;

        public String TransactionKey
        {
            get
            {
                return ((IDatabaseContext)this).TransactionKey;
            }
            set
            {
                ((IDatabaseContext)this).TransactionKey = value;
            }
        }
        public Guid RowGuidColumn
        {
            get
            {
                return _RowGuidColumn;
            }
            set
            {
                this.SetPropertyValue(ref _RowGuidColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NVarCharColumn
        {
            get
            {
                return _NVarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NVarCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Guid PK_RowGuidColumn
        {
            get
            {
                return _PK_RowGuidColumn;
            }
            set
            {
                this.SetPropertyValue(ref _PK_RowGuidColumn, value, this.GetPropertyChangedEventHandler());
            }
        }

        public RowGuidColTableUpdate()
        {
            ConstructorExecuted();
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_SqlServer";
        }
        public override String GetStoredProcedureName()
        {
            return RowGuidColTableUpdate.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand()
        {
            var db = new SqlServerDatabase("");
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@RowGuidColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.RowGuidColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NVarCharColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@PK_RowGuidColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_RowGuidColumn;
            cm.Parameters.Add(p);
            
            for (int i = 0; i < cm.Parameters.Count; i++)
            {
                if (cm.Parameters[i].Value == null) cm.Parameters[i].Value = DBNull.Value;
            }
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<RowGuidColTableUpdate>");
            sb.AppendFormat("RowGuidColumn={0}", this.RowGuidColumn); sb.AppendLine();
            sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
            sb.AppendFormat("PK_RowGuidColumn={0}", this.PK_RowGuidColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
