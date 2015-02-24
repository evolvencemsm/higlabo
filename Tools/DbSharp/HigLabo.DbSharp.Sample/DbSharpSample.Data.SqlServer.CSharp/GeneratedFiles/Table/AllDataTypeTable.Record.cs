﻿using System;
using System.Data;
using System.Text;
using System.ComponentModel;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class AllDataTypeTable
    {
        public partial class Record : TableRecord<Record>, IRecord
        {
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

            public SaveMode SaveMode
            {
                get
                {
                    return ((ISaveMode)this).SaveMode;
                }
                set
                {
                    ((ISaveMode)this).SaveMode = value;
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

            public Record()
            {
                ConstructorExecuted();
            }
            public Record(IRecord record)
            {
                this.SetProperty(record);
                ConstructorExecuted();
            }

            public override String GetTableName()
            {
                return "AllDataTypeTable";
            }
            partial void ConstructorExecuted();
            public override void SetProperty(Record record)
            {
                this.SetProperty(record as IRecord);
            }
            public void SetProperty(IRecord record)
            {
                if (record == null) throw new ArgumentNullException("record");
                var r = record;
                this.PrimaryKeyColumn = r.PrimaryKeyColumn;
                this.TimestampColumn = r.TimestampColumn;
                this.BigIntColumn = r.BigIntColumn;
                this.BinaryColumn = r.BinaryColumn;
                this.ImageColumn = r.ImageColumn;
                this.VarBinaryColumn = r.VarBinaryColumn;
                this.BitColumn = r.BitColumn;
                this.CharColumn = r.CharColumn;
                this.NCharColumn = r.NCharColumn;
                this.NTextColumn = r.NTextColumn;
                this.NVarCharColumn = r.NVarCharColumn;
                this.TextColumn = r.TextColumn;
                this.VarCharColumn = r.VarCharColumn;
                this.XmlColumn = r.XmlColumn;
                this.DateTimeColumn = r.DateTimeColumn;
                this.SmallDateTimeColumn = r.SmallDateTimeColumn;
                this.DateColumn = r.DateColumn;
                this.TimeColumn = r.TimeColumn;
                this.DateTime2Column = r.DateTime2Column;
                this.DecimalColumn = r.DecimalColumn;
                this.MoneyColumn = r.MoneyColumn;
                this.SmallMoneyColumn = r.SmallMoneyColumn;
                this.FloatColumn = r.FloatColumn;
                this.IntColumn = r.IntColumn;
                this.RealColumn = r.RealColumn;
                this.UniqueIdentifierColumn = r.UniqueIdentifierColumn;
                this.SmallIntColumn = r.SmallIntColumn;
                this.TinyIntColumn = r.TinyIntColumn;
                this.DateTimeOffsetColumn = r.DateTimeOffsetColumn;
                this.SqlVariantColumn = r.SqlVariantColumn;
                this.GeometryColumn = r.GeometryColumn;
                this.GeographyColumn = r.GeographyColumn;
                this.HierarchyIDColumn = r.HierarchyIDColumn;
                this.EnumColumn = r.EnumColumn;
                this.NotNullBigIntColumn = r.NotNullBigIntColumn;
                this.NotNullBinaryColumn = r.NotNullBinaryColumn;
                this.NotNullImageColumn = r.NotNullImageColumn;
                this.NotNullVarBinaryColumn = r.NotNullVarBinaryColumn;
                this.NotNullBitColumn = r.NotNullBitColumn;
                this.NotNullCharColumn = r.NotNullCharColumn;
                this.NotNullNCharColumn = r.NotNullNCharColumn;
                this.NotNullNTextColumn = r.NotNullNTextColumn;
                this.NotNullNVarCharColumn = r.NotNullNVarCharColumn;
                this.NotNullTextColumn = r.NotNullTextColumn;
                this.NotNullVarCharColumn = r.NotNullVarCharColumn;
                this.NotNullXmlColumn = r.NotNullXmlColumn;
                this.NotNullDateTimeColumn = r.NotNullDateTimeColumn;
                this.NotNullSmallDateTimeColumn = r.NotNullSmallDateTimeColumn;
                this.NotNullDateColumn = r.NotNullDateColumn;
                this.NotNullTimeColumn = r.NotNullTimeColumn;
                this.NotNullDateTime2Column = r.NotNullDateTime2Column;
                this.NotNullDecimalColumn = r.NotNullDecimalColumn;
                this.NotNullMoneyColumn = r.NotNullMoneyColumn;
                this.NotNullSmallMoneyColumn = r.NotNullSmallMoneyColumn;
                this.NotNullFloatColumn = r.NotNullFloatColumn;
                this.NotNullIntColumn = r.NotNullIntColumn;
                this.NotNullRealColumn = r.NotNullRealColumn;
                this.NotNullUniqueIdentifierColumn = r.NotNullUniqueIdentifierColumn;
                this.NotNullSmallIntColumn = r.NotNullSmallIntColumn;
                this.NotNullTinyIntColumn = r.NotNullTinyIntColumn;
                this.NotNullDateTimeOffsetColumn = r.NotNullDateTimeOffsetColumn;
                this.NotNullSqlVariantColumn = r.NotNullSqlVariantColumn;
                this.NotNullGeometryColumn = r.NotNullGeometryColumn;
                this.NotNullGeographyColumn = r.NotNullGeographyColumn;
                this.NotNullHierarchyIDColumn = r.NotNullHierarchyIDColumn;
                this.NotNullEnumColumn = r.NotNullEnumColumn;
            }
            public override Boolean CompareAllColumn(Record record)
            {
                if (record == null) throw new ArgumentNullException("record");
                var r = record;
                return Object.Equals(this.PrimaryKeyColumn, r.PrimaryKeyColumn) && 
                Object.Equals(this.TimestampColumn, r.TimestampColumn) && 
                Object.Equals(this.BigIntColumn, r.BigIntColumn) && 
                Object.Equals(this.BinaryColumn, r.BinaryColumn) && 
                Object.Equals(this.ImageColumn, r.ImageColumn) && 
                Object.Equals(this.VarBinaryColumn, r.VarBinaryColumn) && 
                Object.Equals(this.BitColumn, r.BitColumn) && 
                Object.Equals(this.CharColumn, r.CharColumn) && 
                Object.Equals(this.NCharColumn, r.NCharColumn) && 
                Object.Equals(this.NTextColumn, r.NTextColumn) && 
                Object.Equals(this.NVarCharColumn, r.NVarCharColumn) && 
                Object.Equals(this.TextColumn, r.TextColumn) && 
                Object.Equals(this.VarCharColumn, r.VarCharColumn) && 
                Object.Equals(this.XmlColumn, r.XmlColumn) && 
                Object.Equals(this.DateTimeColumn, r.DateTimeColumn) && 
                Object.Equals(this.SmallDateTimeColumn, r.SmallDateTimeColumn) && 
                Object.Equals(this.DateColumn, r.DateColumn) && 
                Object.Equals(this.TimeColumn, r.TimeColumn) && 
                Object.Equals(this.DateTime2Column, r.DateTime2Column) && 
                Object.Equals(this.DecimalColumn, r.DecimalColumn) && 
                Object.Equals(this.MoneyColumn, r.MoneyColumn) && 
                Object.Equals(this.SmallMoneyColumn, r.SmallMoneyColumn) && 
                Object.Equals(this.FloatColumn, r.FloatColumn) && 
                Object.Equals(this.IntColumn, r.IntColumn) && 
                Object.Equals(this.RealColumn, r.RealColumn) && 
                Object.Equals(this.UniqueIdentifierColumn, r.UniqueIdentifierColumn) && 
                Object.Equals(this.SmallIntColumn, r.SmallIntColumn) && 
                Object.Equals(this.TinyIntColumn, r.TinyIntColumn) && 
                Object.Equals(this.DateTimeOffsetColumn, r.DateTimeOffsetColumn) && 
                Object.Equals(this.SqlVariantColumn, r.SqlVariantColumn) && 
                Object.Equals(this.GeometryColumn, r.GeometryColumn) && 
                Object.Equals(this.GeographyColumn, r.GeographyColumn) && 
                Object.Equals(this.HierarchyIDColumn, r.HierarchyIDColumn) && 
                Object.Equals(this.EnumColumn, r.EnumColumn) && 
                Object.Equals(this.NotNullBigIntColumn, r.NotNullBigIntColumn) && 
                Object.Equals(this.NotNullBinaryColumn, r.NotNullBinaryColumn) && 
                Object.Equals(this.NotNullImageColumn, r.NotNullImageColumn) && 
                Object.Equals(this.NotNullVarBinaryColumn, r.NotNullVarBinaryColumn) && 
                Object.Equals(this.NotNullBitColumn, r.NotNullBitColumn) && 
                Object.Equals(this.NotNullCharColumn, r.NotNullCharColumn) && 
                Object.Equals(this.NotNullNCharColumn, r.NotNullNCharColumn) && 
                Object.Equals(this.NotNullNTextColumn, r.NotNullNTextColumn) && 
                Object.Equals(this.NotNullNVarCharColumn, r.NotNullNVarCharColumn) && 
                Object.Equals(this.NotNullTextColumn, r.NotNullTextColumn) && 
                Object.Equals(this.NotNullVarCharColumn, r.NotNullVarCharColumn) && 
                Object.Equals(this.NotNullXmlColumn, r.NotNullXmlColumn) && 
                Object.Equals(this.NotNullDateTimeColumn, r.NotNullDateTimeColumn) && 
                Object.Equals(this.NotNullSmallDateTimeColumn, r.NotNullSmallDateTimeColumn) && 
                Object.Equals(this.NotNullDateColumn, r.NotNullDateColumn) && 
                Object.Equals(this.NotNullTimeColumn, r.NotNullTimeColumn) && 
                Object.Equals(this.NotNullDateTime2Column, r.NotNullDateTime2Column) && 
                Object.Equals(this.NotNullDecimalColumn, r.NotNullDecimalColumn) && 
                Object.Equals(this.NotNullMoneyColumn, r.NotNullMoneyColumn) && 
                Object.Equals(this.NotNullSmallMoneyColumn, r.NotNullSmallMoneyColumn) && 
                Object.Equals(this.NotNullFloatColumn, r.NotNullFloatColumn) && 
                Object.Equals(this.NotNullIntColumn, r.NotNullIntColumn) && 
                Object.Equals(this.NotNullRealColumn, r.NotNullRealColumn) && 
                Object.Equals(this.NotNullUniqueIdentifierColumn, r.NotNullUniqueIdentifierColumn) && 
                Object.Equals(this.NotNullSmallIntColumn, r.NotNullSmallIntColumn) && 
                Object.Equals(this.NotNullTinyIntColumn, r.NotNullTinyIntColumn) && 
                Object.Equals(this.NotNullDateTimeOffsetColumn, r.NotNullDateTimeOffsetColumn) && 
                Object.Equals(this.NotNullSqlVariantColumn, r.NotNullSqlVariantColumn) && 
                Object.Equals(this.NotNullGeometryColumn, r.NotNullGeometryColumn) && 
                Object.Equals(this.NotNullGeographyColumn, r.NotNullGeographyColumn) && 
                Object.Equals(this.NotNullHierarchyIDColumn, r.NotNullHierarchyIDColumn) && 
                Object.Equals(this.NotNullEnumColumn, r.NotNullEnumColumn);
            }
            public override Boolean ComparePrimaryKeyColumn(Record record)
            {
                if (record == null) throw new ArgumentNullException("record");
                var r = record;
                return Object.Equals(this.PrimaryKeyColumn, r.PrimaryKeyColumn);
            }
            public override Object GetValue(Int32 index)
            {
                switch (index)
                {
                    case 0: return this.PrimaryKeyColumn;
                    case 1: return this.TimestampColumn;
                    case 2: return this.BigIntColumn;
                    case 3: return this.BinaryColumn;
                    case 4: return this.ImageColumn;
                    case 5: return this.VarBinaryColumn;
                    case 6: return this.BitColumn;
                    case 7: return this.CharColumn;
                    case 8: return this.NCharColumn;
                    case 9: return this.NTextColumn;
                    case 10: return this.NVarCharColumn;
                    case 11: return this.TextColumn;
                    case 12: return this.VarCharColumn;
                    case 13: return this.XmlColumn;
                    case 14: return this.DateTimeColumn;
                    case 15: return this.SmallDateTimeColumn;
                    case 16: return this.DateColumn;
                    case 17: return this.TimeColumn;
                    case 18: return this.DateTime2Column;
                    case 19: return this.DecimalColumn;
                    case 20: return this.MoneyColumn;
                    case 21: return this.SmallMoneyColumn;
                    case 22: return this.FloatColumn;
                    case 23: return this.IntColumn;
                    case 24: return this.RealColumn;
                    case 25: return this.UniqueIdentifierColumn;
                    case 26: return this.SmallIntColumn;
                    case 27: return this.TinyIntColumn;
                    case 28: return this.DateTimeOffsetColumn;
                    case 29: return this.SqlVariantColumn;
                    case 30: return this.GeometryColumn;
                    case 31: return this.GeographyColumn;
                    case 32: return this.HierarchyIDColumn;
                    case 33: return this.EnumColumn;
                    case 34: return this.NotNullBigIntColumn;
                    case 35: return this.NotNullBinaryColumn;
                    case 36: return this.NotNullImageColumn;
                    case 37: return this.NotNullVarBinaryColumn;
                    case 38: return this.NotNullBitColumn;
                    case 39: return this.NotNullCharColumn;
                    case 40: return this.NotNullNCharColumn;
                    case 41: return this.NotNullNTextColumn;
                    case 42: return this.NotNullNVarCharColumn;
                    case 43: return this.NotNullTextColumn;
                    case 44: return this.NotNullVarCharColumn;
                    case 45: return this.NotNullXmlColumn;
                    case 46: return this.NotNullDateTimeColumn;
                    case 47: return this.NotNullSmallDateTimeColumn;
                    case 48: return this.NotNullDateColumn;
                    case 49: return this.NotNullTimeColumn;
                    case 50: return this.NotNullDateTime2Column;
                    case 51: return this.NotNullDecimalColumn;
                    case 52: return this.NotNullMoneyColumn;
                    case 53: return this.NotNullSmallMoneyColumn;
                    case 54: return this.NotNullFloatColumn;
                    case 55: return this.NotNullIntColumn;
                    case 56: return this.NotNullRealColumn;
                    case 57: return this.NotNullUniqueIdentifierColumn;
                    case 58: return this.NotNullSmallIntColumn;
                    case 59: return this.NotNullTinyIntColumn;
                    case 60: return this.NotNullDateTimeOffsetColumn;
                    case 61: return this.NotNullSqlVariantColumn;
                    case 62: return this.NotNullGeometryColumn;
                    case 63: return this.NotNullGeographyColumn;
                    case 64: return this.NotNullHierarchyIDColumn;
                    case 65: return this.NotNullEnumColumn;
                }
                throw new ArgumentOutOfRangeException();
            }
            public override Boolean SetValue(Int32 index, Object value)
            {
                switch (index)
                {
                    case 0:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt64(value);
                            if (newValue == null) return false;
                            this.PrimaryKeyColumn = newValue.Value;
                            return true;
                        }
                    case 1:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.TimestampColumn = newValue;
                            return true;
                        }
                    case 2:
                        if (value == null)
                        {
                            this.BigIntColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt64(value);
                            if (newValue == null) return false;
                            this.BigIntColumn = newValue.Value;
                            return true;
                        }
                    case 3:
                        if (value == null)
                        {
                            this.BinaryColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.BinaryColumn = newValue;
                            return true;
                        }
                    case 4:
                        if (value == null)
                        {
                            this.ImageColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.ImageColumn = newValue;
                            return true;
                        }
                    case 5:
                        if (value == null)
                        {
                            this.VarBinaryColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.VarBinaryColumn = newValue;
                            return true;
                        }
                    case 6:
                        if (value == null)
                        {
                            this.BitColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToBoolean(value);
                            if (newValue == null) return false;
                            this.BitColumn = newValue.Value;
                            return true;
                        }
                    case 7:
                        if (value == null)
                        {
                            this.CharColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.CharColumn = newValue;
                            return true;
                        }
                    case 8:
                        if (value == null)
                        {
                            this.NCharColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NCharColumn = newValue;
                            return true;
                        }
                    case 9:
                        if (value == null)
                        {
                            this.NTextColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NTextColumn = newValue;
                            return true;
                        }
                    case 10:
                        if (value == null)
                        {
                            this.NVarCharColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NVarCharColumn = newValue;
                            return true;
                        }
                    case 11:
                        if (value == null)
                        {
                            this.TextColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.TextColumn = newValue;
                            return true;
                        }
                    case 12:
                        if (value == null)
                        {
                            this.VarCharColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.VarCharColumn = newValue;
                            return true;
                        }
                    case 13:
                        if (value == null)
                        {
                            this.XmlColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.XmlColumn = newValue;
                            return true;
                        }
                    case 14:
                        if (value == null)
                        {
                            this.DateTimeColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.DateTimeColumn = newValue.Value;
                            return true;
                        }
                    case 15:
                        if (value == null)
                        {
                            this.SmallDateTimeColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.SmallDateTimeColumn = newValue.Value;
                            return true;
                        }
                    case 16:
                        if (value == null)
                        {
                            this.DateColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.DateColumn = newValue.Value;
                            return true;
                        }
                    case 17:
                        if (value == null)
                        {
                            this.TimeColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToTimeSpan(value);
                            if (newValue == null) return false;
                            this.TimeColumn = newValue.Value;
                            return true;
                        }
                    case 18:
                        if (value == null)
                        {
                            this.DateTime2Column = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.DateTime2Column = newValue.Value;
                            return true;
                        }
                    case 19:
                        if (value == null)
                        {
                            this.DecimalColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.DecimalColumn = newValue.Value;
                            return true;
                        }
                    case 20:
                        if (value == null)
                        {
                            this.MoneyColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.MoneyColumn = newValue.Value;
                            return true;
                        }
                    case 21:
                        if (value == null)
                        {
                            this.SmallMoneyColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.SmallMoneyColumn = newValue.Value;
                            return true;
                        }
                    case 22:
                        if (value == null)
                        {
                            this.FloatColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDouble(value);
                            if (newValue == null) return false;
                            this.FloatColumn = newValue.Value;
                            return true;
                        }
                    case 23:
                        if (value == null)
                        {
                            this.IntColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt32(value);
                            if (newValue == null) return false;
                            this.IntColumn = newValue.Value;
                            return true;
                        }
                    case 24:
                        if (value == null)
                        {
                            this.RealColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToSingle(value);
                            if (newValue == null) return false;
                            this.RealColumn = newValue.Value;
                            return true;
                        }
                    case 25:
                        if (value == null)
                        {
                            this.UniqueIdentifierColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToGuid(value);
                            if (newValue == null) return false;
                            this.UniqueIdentifierColumn = newValue.Value;
                            return true;
                        }
                    case 26:
                        if (value == null)
                        {
                            this.SmallIntColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt16(value);
                            if (newValue == null) return false;
                            this.SmallIntColumn = newValue.Value;
                            return true;
                        }
                    case 27:
                        if (value == null)
                        {
                            this.TinyIntColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToByte(value);
                            if (newValue == null) return false;
                            this.TinyIntColumn = newValue.Value;
                            return true;
                        }
                    case 28:
                        if (value == null)
                        {
                            this.DateTimeOffsetColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTimeOffset(value);
                            if (newValue == null) return false;
                            this.DateTimeOffsetColumn = newValue.Value;
                            return true;
                        }
                    case 29:
                        if (value == null)
                        {
                            this.SqlVariantColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as Object;
                            if (newValue == null) return false;
                            this.SqlVariantColumn = newValue;
                            return true;
                        }
                    case 30:
                        if (value == null)
                        {
                            this.GeometryColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlGeometry;
                            if (newValue == null) return false;
                            this.GeometryColumn = newValue;
                            return true;
                        }
                    case 31:
                        if (value == null)
                        {
                            this.GeographyColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlGeography;
                            if (newValue == null) return false;
                            this.GeographyColumn = newValue;
                            return true;
                        }
                    case 32:
                        if (value == null)
                        {
                            this.HierarchyIDColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlHierarchyId?;
                            if (newValue == null) return false;
                            this.HierarchyIDColumn = newValue.Value;
                            return true;
                        }
                    case 33:
                        if (value == null)
                        {
                            this.EnumColumn = null;
                            return true;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToEnum<MyEnum>(value);
                            if (newValue == null) return false;
                            this.EnumColumn = newValue.Value;
                            return true;
                        }
                    case 34:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt64(value);
                            if (newValue == null) return false;
                            this.NotNullBigIntColumn = newValue.Value;
                            return true;
                        }
                    case 35:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.NotNullBinaryColumn = newValue;
                            return true;
                        }
                    case 36:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.NotNullImageColumn = newValue;
                            return true;
                        }
                    case 37:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as Byte[];
                            if (newValue == null) return false;
                            this.NotNullVarBinaryColumn = newValue;
                            return true;
                        }
                    case 38:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToBoolean(value);
                            if (newValue == null) return false;
                            this.NotNullBitColumn = newValue.Value;
                            return true;
                        }
                    case 39:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullCharColumn = newValue;
                            return true;
                        }
                    case 40:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullNCharColumn = newValue;
                            return true;
                        }
                    case 41:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullNTextColumn = newValue;
                            return true;
                        }
                    case 42:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullNVarCharColumn = newValue;
                            return true;
                        }
                    case 43:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullTextColumn = newValue;
                            return true;
                        }
                    case 44:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullVarCharColumn = newValue;
                            return true;
                        }
                    case 45:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as String;
                            if (newValue == null) return false;
                            this.NotNullXmlColumn = newValue;
                            return true;
                        }
                    case 46:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.NotNullDateTimeColumn = newValue.Value;
                            return true;
                        }
                    case 47:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.NotNullSmallDateTimeColumn = newValue.Value;
                            return true;
                        }
                    case 48:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.NotNullDateColumn = newValue.Value;
                            return true;
                        }
                    case 49:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToTimeSpan(value);
                            if (newValue == null) return false;
                            this.NotNullTimeColumn = newValue.Value;
                            return true;
                        }
                    case 50:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTime(value);
                            if (newValue == null) return false;
                            this.NotNullDateTime2Column = newValue.Value;
                            return true;
                        }
                    case 51:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.NotNullDecimalColumn = newValue.Value;
                            return true;
                        }
                    case 52:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.NotNullMoneyColumn = newValue.Value;
                            return true;
                        }
                    case 53:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDecimal(value);
                            if (newValue == null) return false;
                            this.NotNullSmallMoneyColumn = newValue.Value;
                            return true;
                        }
                    case 54:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDouble(value);
                            if (newValue == null) return false;
                            this.NotNullFloatColumn = newValue.Value;
                            return true;
                        }
                    case 55:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt32(value);
                            if (newValue == null) return false;
                            this.NotNullIntColumn = newValue.Value;
                            return true;
                        }
                    case 56:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToSingle(value);
                            if (newValue == null) return false;
                            this.NotNullRealColumn = newValue.Value;
                            return true;
                        }
                    case 57:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToGuid(value);
                            if (newValue == null) return false;
                            this.NotNullUniqueIdentifierColumn = newValue.Value;
                            return true;
                        }
                    case 58:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToInt16(value);
                            if (newValue == null) return false;
                            this.NotNullSmallIntColumn = newValue.Value;
                            return true;
                        }
                    case 59:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToByte(value);
                            if (newValue == null) return false;
                            this.NotNullTinyIntColumn = newValue.Value;
                            return true;
                        }
                    case 60:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToDateTimeOffset(value);
                            if (newValue == null) return false;
                            this.NotNullDateTimeOffsetColumn = newValue.Value;
                            return true;
                        }
                    case 61:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as Object;
                            if (newValue == null) return false;
                            this.NotNullSqlVariantColumn = newValue;
                            return true;
                        }
                    case 62:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlGeometry;
                            if (newValue == null) return false;
                            this.NotNullGeometryColumn = newValue;
                            return true;
                        }
                    case 63:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlGeography;
                            if (newValue == null) return false;
                            this.NotNullGeographyColumn = newValue;
                            return true;
                        }
                    case 64:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = value as global::Microsoft.SqlServer.Types.SqlHierarchyId?;
                            if (newValue == null) return false;
                            this.NotNullHierarchyIDColumn = newValue.Value;
                            return true;
                        }
                    case 65:
                        if (value == null)
                        {
                            return false;
                        }
                        else
                        {
                            var newValue = TableRecord.TypeConverter.ToEnum<MyEnum>(value);
                            if (newValue == null) return false;
                            this.NotNullEnumColumn = newValue.Value;
                            return true;
                        }
                }
                throw new ArgumentOutOfRangeException("index", index, "index must be 0-65");
            }
            public override Int32 GetColumnCount()
            {
                return 66;
            }
        }
    }
}
