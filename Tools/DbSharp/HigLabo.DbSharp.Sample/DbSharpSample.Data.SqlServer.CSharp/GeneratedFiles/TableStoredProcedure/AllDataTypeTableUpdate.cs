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
    public partial class AllDataTypeTableUpdate : StoredProcedure
    {
        public const String Name = "AllDataTypeTableUpdate";
        private Int64 _PrimaryKeyColumn;
        private Byte[] _TimestampColumn;
        private Int64? _BigIntColumn;
        private Byte[] _BinaryColumn;
        private Byte[] _ImageColumn;
        private Byte[] _VarBinaryColumn;
        private Boolean? _BitColumn;
        private String _CharColumn = "";
        private String _NCharColumn = "";
        private String _NTextColumn = "";
        private String _NVarCharColumn = "";
        private String _TextColumn = "";
        private String _VarCharColumn = "";
        private String _XmlColumn = "";
        private DateTime? _DateTimeColumn;
        private DateTime? _SmallDateTimeColumn;
        private DateTime? _DateColumn;
        private TimeSpan? _TimeColumn;
        private DateTime? _DateTime2Column;
        private Decimal? _DecimalColumn;
        private Decimal? _MoneyColumn;
        private Decimal? _SmallMoneyColumn;
        private Double? _FloatColumn;
        private Int32? _IntColumn;
        private Single? _RealColumn;
        private Guid? _UniqueIdentifierColumn;
        private Int16? _SmallIntColumn;
        private Byte? _TinyIntColumn;
        private DateTimeOffset? _DateTimeOffsetColumn;
        private Object _SqlVariantColumn;
        private global::Microsoft.SqlServer.Types.SqlGeometry _GeometryColumn;
        private global::Microsoft.SqlServer.Types.SqlGeography _GeographyColumn;
        private global::Microsoft.SqlServer.Types.SqlHierarchyId? _HierarchyIDColumn;
        private MyEnum? _EnumColumn;
        private Int64 _NotNullBigIntColumn;
        private Byte[] _NotNullBinaryColumn;
        private Byte[] _NotNullImageColumn;
        private Byte[] _NotNullVarBinaryColumn;
        private Boolean _NotNullBitColumn;
        private String _NotNullCharColumn = "";
        private String _NotNullNCharColumn = "";
        private String _NotNullNTextColumn = "";
        private String _NotNullNVarCharColumn = "";
        private String _NotNullTextColumn = "";
        private String _NotNullVarCharColumn = "";
        private String _NotNullXmlColumn = "";
        private DateTime _NotNullDateTimeColumn;
        private DateTime _NotNullSmallDateTimeColumn;
        private DateTime _NotNullDateColumn;
        private TimeSpan _NotNullTimeColumn;
        private DateTime _NotNullDateTime2Column;
        private Decimal _NotNullDecimalColumn;
        private Decimal _NotNullMoneyColumn;
        private Decimal _NotNullSmallMoneyColumn;
        private Double _NotNullFloatColumn;
        private Int32 _NotNullIntColumn;
        private Single _NotNullRealColumn;
        private Guid _NotNullUniqueIdentifierColumn;
        private Int16 _NotNullSmallIntColumn;
        private Byte _NotNullTinyIntColumn;
        private DateTimeOffset _NotNullDateTimeOffsetColumn;
        private Object _NotNullSqlVariantColumn;
        private global::Microsoft.SqlServer.Types.SqlGeometry _NotNullGeometryColumn;
        private global::Microsoft.SqlServer.Types.SqlGeography _NotNullGeographyColumn;
        private global::Microsoft.SqlServer.Types.SqlHierarchyId _NotNullHierarchyIDColumn;
        private MyEnum _NotNullEnumColumn;
        private Int64 _PK_PrimaryKeyColumn;
        private Byte[] _PK_TimestampColumn;

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
        public Int64 PrimaryKeyColumn
        {
            get
            {
                return _PrimaryKeyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _PrimaryKeyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] TimestampColumn
        {
            get
            {
                return _TimestampColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TimestampColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int64? BigIntColumn
        {
            get
            {
                return _BigIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BigIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] BinaryColumn
        {
            get
            {
                return _BinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] ImageColumn
        {
            get
            {
                return _ImageColumn;
            }
            set
            {
                this.SetPropertyValue(ref _ImageColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] VarBinaryColumn
        {
            get
            {
                return _VarBinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _VarBinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Boolean? BitColumn
        {
            get
            {
                return _BitColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BitColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String CharColumn
        {
            get
            {
                return _CharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _CharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NCharColumn
        {
            get
            {
                return _NCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NTextColumn
        {
            get
            {
                return _NTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NTextColumn, value, this.GetPropertyChangedEventHandler());
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
        public String TextColumn
        {
            get
            {
                return _TextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String VarCharColumn
        {
            get
            {
                return _VarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _VarCharColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String XmlColumn
        {
            get
            {
                return _XmlColumn;
            }
            set
            {
                this.SetPropertyValue(ref _XmlColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? DateTimeColumn
        {
            get
            {
                return _DateTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DateTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? SmallDateTimeColumn
        {
            get
            {
                return _SmallDateTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallDateTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? DateColumn
        {
            get
            {
                return _DateColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DateColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public TimeSpan? TimeColumn
        {
            get
            {
                return _TimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime? DateTime2Column
        {
            get
            {
                return _DateTime2Column;
            }
            set
            {
                this.SetPropertyValue(ref _DateTime2Column, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal? DecimalColumn
        {
            get
            {
                return _DecimalColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DecimalColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal? MoneyColumn
        {
            get
            {
                return _MoneyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MoneyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal? SmallMoneyColumn
        {
            get
            {
                return _SmallMoneyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallMoneyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Double? FloatColumn
        {
            get
            {
                return _FloatColumn;
            }
            set
            {
                this.SetPropertyValue(ref _FloatColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int32? IntColumn
        {
            get
            {
                return _IntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _IntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Single? RealColumn
        {
            get
            {
                return _RealColumn;
            }
            set
            {
                this.SetPropertyValue(ref _RealColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Guid? UniqueIdentifierColumn
        {
            get
            {
                return _UniqueIdentifierColumn;
            }
            set
            {
                this.SetPropertyValue(ref _UniqueIdentifierColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int16? SmallIntColumn
        {
            get
            {
                return _SmallIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte? TinyIntColumn
        {
            get
            {
                return _TinyIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTimeOffset? DateTimeOffsetColumn
        {
            get
            {
                return _DateTimeOffsetColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DateTimeOffsetColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Object SqlVariantColumn
        {
            get
            {
                return _SqlVariantColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SqlVariantColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlGeometry GeometryColumn
        {
            get
            {
                return _GeometryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _GeometryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlGeography GeographyColumn
        {
            get
            {
                return _GeographyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _GeographyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlHierarchyId? HierarchyIDColumn
        {
            get
            {
                return _HierarchyIDColumn;
            }
            set
            {
                this.SetPropertyValue(ref _HierarchyIDColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public MyEnum? EnumColumn
        {
            get
            {
                return _EnumColumn;
            }
            set
            {
                this.SetPropertyValue(ref _EnumColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int64 NotNullBigIntColumn
        {
            get
            {
                return _NotNullBigIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullBigIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] NotNullBinaryColumn
        {
            get
            {
                return _NotNullBinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullBinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] NotNullImageColumn
        {
            get
            {
                return _NotNullImageColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullImageColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] NotNullVarBinaryColumn
        {
            get
            {
                return _NotNullVarBinaryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullVarBinaryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Boolean NotNullBitColumn
        {
            get
            {
                return _NotNullBitColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullBitColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullCharColumn
        {
            get
            {
                return _NotNullCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullCharColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullNCharColumn
        {
            get
            {
                return _NotNullNCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullNCharColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullNTextColumn
        {
            get
            {
                return _NotNullNTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullNTextColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullNVarCharColumn
        {
            get
            {
                return _NotNullNVarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullNVarCharColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullTextColumn
        {
            get
            {
                return _NotNullTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTextColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullVarCharColumn
        {
            get
            {
                return _NotNullVarCharColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullVarCharColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullXmlColumn
        {
            get
            {
                return _NotNullXmlColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullXmlColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime NotNullDateTimeColumn
        {
            get
            {
                return _NotNullDateTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDateTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime NotNullSmallDateTimeColumn
        {
            get
            {
                return _NotNullSmallDateTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSmallDateTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime NotNullDateColumn
        {
            get
            {
                return _NotNullDateColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDateColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public TimeSpan NotNullTimeColumn
        {
            get
            {
                return _NotNullTimeColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTimeColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTime NotNullDateTime2Column
        {
            get
            {
                return _NotNullDateTime2Column;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDateTime2Column, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal NotNullDecimalColumn
        {
            get
            {
                return _NotNullDecimalColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDecimalColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal NotNullMoneyColumn
        {
            get
            {
                return _NotNullMoneyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullMoneyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Decimal NotNullSmallMoneyColumn
        {
            get
            {
                return _NotNullSmallMoneyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSmallMoneyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Double NotNullFloatColumn
        {
            get
            {
                return _NotNullFloatColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullFloatColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int32 NotNullIntColumn
        {
            get
            {
                return _NotNullIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Single NotNullRealColumn
        {
            get
            {
                return _NotNullRealColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullRealColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Guid NotNullUniqueIdentifierColumn
        {
            get
            {
                return _NotNullUniqueIdentifierColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullUniqueIdentifierColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int16 NotNullSmallIntColumn
        {
            get
            {
                return _NotNullSmallIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSmallIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte NotNullTinyIntColumn
        {
            get
            {
                return _NotNullTinyIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTinyIntColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public DateTimeOffset NotNullDateTimeOffsetColumn
        {
            get
            {
                return _NotNullDateTimeOffsetColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDateTimeOffsetColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Object NotNullSqlVariantColumn
        {
            get
            {
                return _NotNullSqlVariantColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSqlVariantColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlGeometry NotNullGeometryColumn
        {
            get
            {
                return _NotNullGeometryColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullGeometryColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlGeography NotNullGeographyColumn
        {
            get
            {
                return _NotNullGeographyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullGeographyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::Microsoft.SqlServer.Types.SqlHierarchyId NotNullHierarchyIDColumn
        {
            get
            {
                return _NotNullHierarchyIDColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullHierarchyIDColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public MyEnum NotNullEnumColumn
        {
            get
            {
                return _NotNullEnumColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullEnumColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Int64 PK_PrimaryKeyColumn
        {
            get
            {
                return _PK_PrimaryKeyColumn;
            }
            set
            {
                this.SetPropertyValue(ref _PK_PrimaryKeyColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] PK_TimestampColumn
        {
            get
            {
                return _PK_TimestampColumn;
            }
            set
            {
                this.SetPropertyValue(ref _PK_TimestampColumn, value, this.GetPropertyChangedEventHandler());
            }
        }

        public AllDataTypeTableUpdate()
        {
            ConstructorExecuted();
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_SqlServer";
        }
        public override String GetStoredProcedureName()
        {
            return AllDataTypeTableUpdate.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand()
        {
            var db = new SqlServerDatabase("");
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("@PrimaryKeyColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PrimaryKeyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TimestampColumn", SqlDbType.Timestamp, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimestampColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BigIntColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BigIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BinaryColumn", SqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.BinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@ImageColumn", SqlDbType.Image, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.ImageColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@VarBinaryColumn", SqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.VarBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@BitColumn", SqlDbType.Bit, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BitColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@CharColumn", SqlDbType.Char, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.CharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NCharColumn", SqlDbType.NChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NTextColumn", SqlDbType.NText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 1073741823;
            p.Value = this.NTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NVarCharColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TextColumn", SqlDbType.Text, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.TextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@VarCharColumn", SqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.VarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@XmlColumn", SqlDbType.Xml, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.Value = this.XmlColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTimeColumn", SqlDbType.DateTime, null, 3);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallDateTimeColumn", SqlDbType.SmallDateTime, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.SmallDateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateColumn", SqlDbType.Date, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TimeColumn", SqlDbType.Time, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.TimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTime2Column", SqlDbType.DateTime2, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateTime2Column;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DecimalColumn", SqlDbType.Decimal, 18, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DecimalColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@MoneyColumn", SqlDbType.Money, 19, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.MoneyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallMoneyColumn", SqlDbType.SmallMoney, 10, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.SmallMoneyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@FloatColumn", SqlDbType.Float, 53, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.FloatColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@IntColumn", SqlDbType.Int, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.IntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@RealColumn", SqlDbType.Real, 24, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.RealColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@UniqueIdentifierColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.UniqueIdentifierColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SmallIntColumn", SqlDbType.SmallInt, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.SmallIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@TinyIntColumn", SqlDbType.TinyInt, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.TinyIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@DateTimeOffsetColumn", SqlDbType.DateTimeOffset, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateTimeOffsetColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@SqlVariantColumn", SqlDbType.Variant, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 0;
            p.Value = this.SqlVariantColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@GeometryColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.SetUdtTypeName("geometry");
            p.Value = this.GeometryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@GeographyColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.SetUdtTypeName("geography");
            p.Value = this.GeographyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@HierarchyIDColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 892;
            p.SetUdtTypeName("hierarchyid");
            p.Value = this.HierarchyIDColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@EnumColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 20;
            p.Value = this.EnumColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullBigIntColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullBigIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullBinaryColumn", SqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullImageColumn", SqlDbType.Image, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.NotNullImageColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullVarBinaryColumn", SqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullVarBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullBitColumn", SqlDbType.Bit, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullBitColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullCharColumn", SqlDbType.Char, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullNCharColumn", SqlDbType.NChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullNCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullNTextColumn", SqlDbType.NText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 1073741823;
            p.Value = this.NotNullNTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullNVarCharColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullNVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullTextColumn", SqlDbType.Text, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.NotNullTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullVarCharColumn", SqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullXmlColumn", SqlDbType.Xml, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.Value = this.NotNullXmlColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullDateTimeColumn", SqlDbType.DateTime, null, 3);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullSmallDateTimeColumn", SqlDbType.SmallDateTime, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullSmallDateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullDateColumn", SqlDbType.Date, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullTimeColumn", SqlDbType.Time, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullDateTime2Column", SqlDbType.DateTime2, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateTime2Column;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullDecimalColumn", SqlDbType.Decimal, 18, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDecimalColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullMoneyColumn", SqlDbType.Money, 19, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullMoneyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullSmallMoneyColumn", SqlDbType.SmallMoney, 10, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullSmallMoneyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullFloatColumn", SqlDbType.Float, 53, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullFloatColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullIntColumn", SqlDbType.Int, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullRealColumn", SqlDbType.Real, 24, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullRealColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullUniqueIdentifierColumn", SqlDbType.UniqueIdentifier, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullUniqueIdentifierColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullSmallIntColumn", SqlDbType.SmallInt, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullSmallIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullTinyIntColumn", SqlDbType.TinyInt, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullTinyIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullDateTimeOffsetColumn", SqlDbType.DateTimeOffset, null, 7);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateTimeOffsetColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullSqlVariantColumn", SqlDbType.Variant, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 0;
            p.Value = this.NotNullSqlVariantColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullGeometryColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.SetUdtTypeName("geometry");
            p.Value = this.NotNullGeometryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullGeographyColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = -1;
            p.SetUdtTypeName("geography");
            p.Value = this.NotNullGeographyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullHierarchyIDColumn", SqlDbType.Udt, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 892;
            p.SetUdtTypeName("hierarchyid");
            p.Value = this.NotNullHierarchyIDColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@NotNullEnumColumn", SqlDbType.NVarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 20;
            p.Value = this.NotNullEnumColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@PK_PrimaryKeyColumn", SqlDbType.BigInt, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_PrimaryKeyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("@PK_TimestampColumn", SqlDbType.Timestamp, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_TimestampColumn;
            cm.Parameters.Add(p);
            
            for (int i = 0; i < cm.Parameters.Count; i++)
            {
                if (cm.Parameters[i].Value == null) cm.Parameters[i].Value = DBNull.Value;
            }
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
            var cm = command;
            DbParameter p = null;
            p = cm.Parameters[1] as DbParameter;
            if (p.Value != DBNull.Value && p.Value != null) this.TimestampColumn = (Byte[])p.Value;
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<AllDataTypeTableUpdate>");
            sb.AppendFormat("PrimaryKeyColumn={0}", this.PrimaryKeyColumn); sb.AppendLine();
            sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
            sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
            sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
            sb.AppendFormat("ImageColumn={0}", this.ImageColumn); sb.AppendLine();
            sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
            sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
            sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
            sb.AppendFormat("NTextColumn={0}", this.NTextColumn); sb.AppendLine();
            sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
            sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
            sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
            sb.AppendFormat("XmlColumn={0}", this.XmlColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
            sb.AppendFormat("SmallDateTimeColumn={0}", this.SmallDateTimeColumn); sb.AppendLine();
            sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
            sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
            sb.AppendFormat("DateTime2Column={0}", this.DateTime2Column); sb.AppendLine();
            sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
            sb.AppendFormat("MoneyColumn={0}", this.MoneyColumn); sb.AppendLine();
            sb.AppendFormat("SmallMoneyColumn={0}", this.SmallMoneyColumn); sb.AppendLine();
            sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
            sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
            sb.AppendFormat("RealColumn={0}", this.RealColumn); sb.AppendLine();
            sb.AppendFormat("UniqueIdentifierColumn={0}", this.UniqueIdentifierColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeOffsetColumn={0}", this.DateTimeOffsetColumn); sb.AppendLine();
            sb.AppendFormat("SqlVariantColumn={0}", this.SqlVariantColumn); sb.AppendLine();
            sb.AppendFormat("GeometryColumn={0}", this.GeometryColumn); sb.AppendLine();
            sb.AppendFormat("GeographyColumn={0}", this.GeographyColumn); sb.AppendLine();
            sb.AppendFormat("HierarchyIDColumn={0}", this.HierarchyIDColumn); sb.AppendLine();
            sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBigIntColumn={0}", this.NotNullBigIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBinaryColumn={0}", this.NotNullBinaryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullImageColumn={0}", this.NotNullImageColumn); sb.AppendLine();
            sb.AppendFormat("NotNullVarBinaryColumn={0}", this.NotNullVarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBitColumn={0}", this.NotNullBitColumn); sb.AppendLine();
            sb.AppendFormat("NotNullCharColumn={0}", this.NotNullCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullNCharColumn={0}", this.NotNullNCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullNTextColumn={0}", this.NotNullNTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullNVarCharColumn={0}", this.NotNullNVarCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTextColumn={0}", this.NotNullTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullVarCharColumn={0}", this.NotNullVarCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullXmlColumn={0}", this.NotNullXmlColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateTimeColumn={0}", this.NotNullDateTimeColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSmallDateTimeColumn={0}", this.NotNullSmallDateTimeColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateColumn={0}", this.NotNullDateColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTimeColumn={0}", this.NotNullTimeColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateTime2Column={0}", this.NotNullDateTime2Column); sb.AppendLine();
            sb.AppendFormat("NotNullDecimalColumn={0}", this.NotNullDecimalColumn); sb.AppendLine();
            sb.AppendFormat("NotNullMoneyColumn={0}", this.NotNullMoneyColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSmallMoneyColumn={0}", this.NotNullSmallMoneyColumn); sb.AppendLine();
            sb.AppendFormat("NotNullFloatColumn={0}", this.NotNullFloatColumn); sb.AppendLine();
            sb.AppendFormat("NotNullIntColumn={0}", this.NotNullIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullRealColumn={0}", this.NotNullRealColumn); sb.AppendLine();
            sb.AppendFormat("NotNullUniqueIdentifierColumn={0}", this.NotNullUniqueIdentifierColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSmallIntColumn={0}", this.NotNullSmallIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTinyIntColumn={0}", this.NotNullTinyIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateTimeOffsetColumn={0}", this.NotNullDateTimeOffsetColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSqlVariantColumn={0}", this.NotNullSqlVariantColumn); sb.AppendLine();
            sb.AppendFormat("NotNullGeometryColumn={0}", this.NotNullGeometryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullGeographyColumn={0}", this.NotNullGeographyColumn); sb.AppendLine();
            sb.AppendFormat("NotNullHierarchyIDColumn={0}", this.NotNullHierarchyIDColumn); sb.AppendLine();
            sb.AppendFormat("NotNullEnumColumn={0}", this.NotNullEnumColumn); sb.AppendLine();
            sb.AppendFormat("PK_PrimaryKeyColumn={0}", this.PK_PrimaryKeyColumn); sb.AppendLine();
            sb.AppendFormat("PK_TimestampColumn={0}", this.PK_TimestampColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
