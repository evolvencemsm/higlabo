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
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class alldatatypetableUpdate : StoredProcedure
    {
        public const String Name = "alldatatypetableUpdate";
        private Int64 _PrimaryKeyColumn;
        private DateTime _TimestampColumn;
        private String _CharColumn = "";
        private String _VarCharColumn = "";
        private Boolean? _BitColumn;
        private SByte? _TinyIntColumn;
        private Int16? _SmallIntColumn;
        private Int32? _MediumIntColumn;
        private Int32? _IntColumn;
        private Int64? _BigIntColumn;
        private Byte? _TinyIntUnsignedColumn;
        private UInt16? _SmallIntUnsignedColumn;
        private UInt32? _MediumIntUnsignedColumn;
        private UInt32? _IntUnsignedColumn;
        private UInt64? _BigIntUnsignedColumn;
        private Single? _FloatColumn;
        private Double? _DoubleColumn;
        private Decimal? _DecimalColumn;
        private Decimal? _NumericColumn;
        private DateTime? _DateColumn;
        private DateTime? _DateTimeColumn;
        private TimeSpan? _TimeColumn;
        private Int32? _YearColumn;
        private Byte[] _BinaryColumn;
        private Byte[] _VarBinaryColumn;
        private Byte[] _TinyBlobColumn;
        private Byte[] _MediumBlobColumn;
        private Byte[] _BlobColumn;
        private Byte[] _LongBlobColumn;
        private String _TinyTextColumn = "";
        private String _MediumTextColumn = "";
        private String _TextColumn = "";
        private String _LongTextColumn = "";
        private global::MySql.Data.Types.MySqlGeometry? _GeometryColumn;
        private MyEnum? _EnumColumn;
        private MySet? _SetColumn;
        private String _NotNullCharColumn = "";
        private String _NotNullVarCharColumn = "";
        private Boolean _NotNullBitColumn;
        private SByte _NotNullTinyIntColumn;
        private Int16 _NotNullSmallIntColumn;
        private Int32 _NotNullMediumIntColumn;
        private Int32 _NotNullIntColumn;
        private Int64 _NotNullBigIntColumn;
        private Byte _NotNullTinyIntUnsignedColumn;
        private UInt16 _NotNullSmallIntUnsignedColumn;
        private UInt32 _NotNullMediumIntUnsignedColumn;
        private UInt32 _NotNullIntUnsignedColumn;
        private UInt64 _NotNullBigIntUnsignedColumn;
        private Single _NotNullFloatColumn;
        private Double _NotNullDoubleColumn;
        private Decimal _NotNullDecimalColumn;
        private Decimal _NotNullNumericColumn;
        private DateTime _NotNullDateColumn;
        private DateTime _NotNullDateTimeColumn;
        private TimeSpan _NotNullTimeColumn;
        private Int32 _NotNullYearColumn;
        private Byte[] _NotNullBinaryColumn;
        private Byte[] _NotNullVarBinaryColumn;
        private Byte[] _NotNullTinyBlobColumn;
        private String _NotNullTinyTextColumn = "";
        private Byte[] _NotNullBlobColumn;
        private String _NotNullTextColumn = "";
        private Byte[] _NotNullMediumBlobColumn;
        private String _NotNullMediumTextColumn = "";
        private Byte[] _NotNullLongBlobColumn;
        private String _NotNullLongTextColumn = "";
        private global::MySql.Data.Types.MySqlGeometry _NotNullGeometryColumn;
        private MyEnum _NotNullEnumColumn;
        private MySet _NotNullSetColumn;
        private Int64 _PK_PrimaryKeyColumn;
        private DateTime _PK_TimestampColumn;

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
        public DateTime TimestampColumn
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
        public SByte? TinyIntColumn
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
        public Int32? MediumIntColumn
        {
            get
            {
                return _MediumIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumIntColumn, value, this.GetPropertyChangedEventHandler());
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
        public Byte? TinyIntUnsignedColumn
        {
            get
            {
                return _TinyIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt16? SmallIntUnsignedColumn
        {
            get
            {
                return _SmallIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SmallIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32? MediumIntUnsignedColumn
        {
            get
            {
                return _MediumIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32? IntUnsignedColumn
        {
            get
            {
                return _IntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _IntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt64? BigIntUnsignedColumn
        {
            get
            {
                return _BigIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BigIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Single? FloatColumn
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
        public Double? DoubleColumn
        {
            get
            {
                return _DoubleColumn;
            }
            set
            {
                this.SetPropertyValue(ref _DoubleColumn, value, this.GetPropertyChangedEventHandler());
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
        public Decimal? NumericColumn
        {
            get
            {
                return _NumericColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NumericColumn, value, this.GetPropertyChangedEventHandler());
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
        public Int32? YearColumn
        {
            get
            {
                return _YearColumn;
            }
            set
            {
                this.SetPropertyValue(ref _YearColumn, value, this.GetPropertyChangedEventHandler());
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
        public Byte[] TinyBlobColumn
        {
            get
            {
                return _TinyBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] MediumBlobColumn
        {
            get
            {
                return _MediumBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] BlobColumn
        {
            get
            {
                return _BlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _BlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] LongBlobColumn
        {
            get
            {
                return _LongBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _LongBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String TinyTextColumn
        {
            get
            {
                return _TinyTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _TinyTextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String MediumTextColumn
        {
            get
            {
                return _MediumTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _MediumTextColumn, value, this.GetPropertyChangedEventHandler());
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
        public String LongTextColumn
        {
            get
            {
                return _LongTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _LongTextColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public global::MySql.Data.Types.MySqlGeometry? GeometryColumn
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
        public MySet? SetColumn
        {
            get
            {
                return _SetColumn;
            }
            set
            {
                this.SetPropertyValue(ref _SetColumn, value, this.GetPropertyChangedEventHandler());
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
        public SByte NotNullTinyIntColumn
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
        public Int32 NotNullMediumIntColumn
        {
            get
            {
                return _NotNullMediumIntColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullMediumIntColumn, value, this.GetPropertyChangedEventHandler());
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
        public Byte NotNullTinyIntUnsignedColumn
        {
            get
            {
                return _NotNullTinyIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTinyIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt16 NotNullSmallIntUnsignedColumn
        {
            get
            {
                return _NotNullSmallIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSmallIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32 NotNullMediumIntUnsignedColumn
        {
            get
            {
                return _NotNullMediumIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullMediumIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt32 NotNullIntUnsignedColumn
        {
            get
            {
                return _NotNullIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public UInt64 NotNullBigIntUnsignedColumn
        {
            get
            {
                return _NotNullBigIntUnsignedColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullBigIntUnsignedColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public Single NotNullFloatColumn
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
        public Double NotNullDoubleColumn
        {
            get
            {
                return _NotNullDoubleColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullDoubleColumn, value, this.GetPropertyChangedEventHandler());
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
        public Decimal NotNullNumericColumn
        {
            get
            {
                return _NotNullNumericColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullNumericColumn, value, this.GetPropertyChangedEventHandler());
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
        public Int32 NotNullYearColumn
        {
            get
            {
                return _NotNullYearColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullYearColumn, value, this.GetPropertyChangedEventHandler());
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
        public Byte[] NotNullTinyBlobColumn
        {
            get
            {
                return _NotNullTinyBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTinyBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullTinyTextColumn
        {
            get
            {
                return _NotNullTinyTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullTinyTextColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] NotNullBlobColumn
        {
            get
            {
                return _NotNullBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullBlobColumn, value, this.GetPropertyChangedEventHandler());
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
        public Byte[] NotNullMediumBlobColumn
        {
            get
            {
                return _NotNullMediumBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullMediumBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullMediumTextColumn
        {
            get
            {
                return _NotNullMediumTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullMediumTextColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public Byte[] NotNullLongBlobColumn
        {
            get
            {
                return _NotNullLongBlobColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullLongBlobColumn, value, this.GetPropertyChangedEventHandler());
            }
        }
        public String NotNullLongTextColumn
        {
            get
            {
                return _NotNullLongTextColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullLongTextColumn, value ?? "", this.GetPropertyChangedEventHandler());
            }
        }
        public global::MySql.Data.Types.MySqlGeometry NotNullGeometryColumn
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
        public MySet NotNullSetColumn
        {
            get
            {
                return _NotNullSetColumn;
            }
            set
            {
                this.SetPropertyValue(ref _NotNullSetColumn, value, this.GetPropertyChangedEventHandler());
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
        public DateTime PK_TimestampColumn
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

        public alldatatypetableUpdate()
        {
            ConstructorExecuted();
        }

        public override String GetDatabaseKey()
        {
            return "DbSharpSample_MySql";
        }
        public override String GetStoredProcedureName()
        {
            return alldatatypetableUpdate.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand()
        {
            var db = new MySqlDatabase("");
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            
            DbParameter p = null;
            
            p = db.CreateParameter("PrimaryKeyColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PrimaryKeyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TimestampColumn", MySqlDbType.Timestamp, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.InputOutput;
            p.Value = this.TimestampColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("CharColumn", MySqlDbType.String, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.CharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("VarCharColumn", MySqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.VarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BitColumn", MySqlDbType.Bit, 1, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BitColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyIntColumn", MySqlDbType.Byte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.TinyIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SmallIntColumn", MySqlDbType.Int16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.SmallIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumIntColumn", MySqlDbType.Int24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.MediumIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("IntColumn", MySqlDbType.Int32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.IntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BigIntColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BigIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyIntUnsignedColumn", MySqlDbType.UByte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.TinyIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SmallIntUnsignedColumn", MySqlDbType.UInt16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.SmallIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumIntUnsignedColumn", MySqlDbType.UInt24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.MediumIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("IntUnsignedColumn", MySqlDbType.UInt32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.IntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BigIntUnsignedColumn", MySqlDbType.UInt64, 20, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.BigIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("FloatColumn", MySqlDbType.Float, 8, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.FloatColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DoubleColumn", MySqlDbType.Double, 9, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DoubleColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DecimalColumn", MySqlDbType.Decimal, 10, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DecimalColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NumericColumn", MySqlDbType.Decimal, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NumericColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DateColumn", MySqlDbType.Date, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("DateTimeColumn", MySqlDbType.DateTime, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.DateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TimeColumn", MySqlDbType.Time, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.TimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("YearColumn", MySqlDbType.Year, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.YearColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BinaryColumn", MySqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.BinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("VarBinaryColumn", MySqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.VarBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyBlobColumn", MySqlDbType.TinyBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 255;
            p.Value = this.TinyBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumBlobColumn", MySqlDbType.MediumBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.MediumBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("BlobColumn", MySqlDbType.Blob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 65535;
            p.Value = this.BlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("LongBlobColumn", MySqlDbType.LongBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.LongBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TinyTextColumn", MySqlDbType.TinyText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 255;
            p.Value = this.TinyTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("MediumTextColumn", MySqlDbType.MediumText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.MediumTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("TextColumn", MySqlDbType.MediumText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.TextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("LongTextColumn", MySqlDbType.LongText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.LongTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("GeometryColumn", MySqlDbType.Geometry, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.GeometryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("EnumColumn", MySqlDbType.Enum, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 7;
            p.Value = this.EnumColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("SetColumn", MySqlDbType.Set, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 20;
            p.Value = this.SetColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullCharColumn", MySqlDbType.String, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullVarCharColumn", MySqlDbType.VarChar, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullVarCharColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullBitColumn", MySqlDbType.Bit, 1, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullBitColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTinyIntColumn", MySqlDbType.Byte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullTinyIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullSmallIntColumn", MySqlDbType.Int16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullSmallIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullMediumIntColumn", MySqlDbType.Int24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullMediumIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullIntColumn", MySqlDbType.Int32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullBigIntColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullBigIntColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTinyIntUnsignedColumn", MySqlDbType.UByte, 3, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullTinyIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullSmallIntUnsignedColumn", MySqlDbType.UInt16, 5, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullSmallIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullMediumIntUnsignedColumn", MySqlDbType.UInt24, 7, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullMediumIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullIntUnsignedColumn", MySqlDbType.UInt32, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullBigIntUnsignedColumn", MySqlDbType.UInt64, 20, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullBigIntUnsignedColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullFloatColumn", MySqlDbType.Float, 8, 4);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullFloatColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullDoubleColumn", MySqlDbType.Double, 9, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDoubleColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullDecimalColumn", MySqlDbType.Decimal, 10, 5);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDecimalColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullNumericColumn", MySqlDbType.Decimal, 10, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullNumericColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullDateColumn", MySqlDbType.Date, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullDateTimeColumn", MySqlDbType.DateTime, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullDateTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTimeColumn", MySqlDbType.Time, null, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullTimeColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullYearColumn", MySqlDbType.Year, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullYearColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullBinaryColumn", MySqlDbType.Binary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullVarBinaryColumn", MySqlDbType.VarBinary, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 100;
            p.Value = this.NotNullVarBinaryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTinyBlobColumn", MySqlDbType.TinyBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 255;
            p.Value = this.NotNullTinyBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTinyTextColumn", MySqlDbType.TinyText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 255;
            p.Value = this.NotNullTinyTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullBlobColumn", MySqlDbType.Blob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 65535;
            p.Value = this.NotNullBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullTextColumn", MySqlDbType.MediumText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.NotNullTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullMediumBlobColumn", MySqlDbType.MediumBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.NotNullMediumBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullMediumTextColumn", MySqlDbType.MediumText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 16777215;
            p.Value = this.NotNullMediumTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullLongBlobColumn", MySqlDbType.LongBlob, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.NotNullLongBlobColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullLongTextColumn", MySqlDbType.LongText, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 2147483647;
            p.Value = this.NotNullLongTextColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullGeometryColumn", MySqlDbType.Geometry, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.NotNullGeometryColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullEnumColumn", MySqlDbType.Enum, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 7;
            p.Value = this.NotNullEnumColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("NotNullSetColumn", MySqlDbType.Set, null, null);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Size = 20;
            p.Value = this.NotNullSetColumn.ToStringFromEnum();
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("PK_PrimaryKeyColumn", MySqlDbType.Int64, 19, 0);
            p.SourceColumn = p.ParameterName;
            p.Direction = ParameterDirection.Input;
            p.Value = this.PK_PrimaryKeyColumn;
            cm.Parameters.Add(p);
            
            p = db.CreateParameter("PK_TimestampColumn", MySqlDbType.Timestamp, null, 0);
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
            if (p.Value != DBNull.Value && p.Value != null) this.TimestampColumn = (DateTime)p.Value;
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<alldatatypetableUpdate>");
            sb.AppendFormat("PrimaryKeyColumn={0}", this.PrimaryKeyColumn); sb.AppendLine();
            sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
            sb.AppendFormat("CharColumn={0}", this.CharColumn); sb.AppendLine();
            sb.AppendFormat("VarCharColumn={0}", this.VarCharColumn); sb.AppendLine();
            sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntColumn={0}", this.TinyIntColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntColumn={0}", this.SmallIntColumn); sb.AppendLine();
            sb.AppendFormat("MediumIntColumn={0}", this.MediumIntColumn); sb.AppendLine();
            sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
            sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
            sb.AppendFormat("TinyIntUnsignedColumn={0}", this.TinyIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("SmallIntUnsignedColumn={0}", this.SmallIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("MediumIntUnsignedColumn={0}", this.MediumIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("IntUnsignedColumn={0}", this.IntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("BigIntUnsignedColumn={0}", this.BigIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
            sb.AppendFormat("DoubleColumn={0}", this.DoubleColumn); sb.AppendLine();
            sb.AppendFormat("DecimalColumn={0}", this.DecimalColumn); sb.AppendLine();
            sb.AppendFormat("NumericColumn={0}", this.NumericColumn); sb.AppendLine();
            sb.AppendFormat("DateColumn={0}", this.DateColumn); sb.AppendLine();
            sb.AppendFormat("DateTimeColumn={0}", this.DateTimeColumn); sb.AppendLine();
            sb.AppendFormat("TimeColumn={0}", this.TimeColumn); sb.AppendLine();
            sb.AppendFormat("YearColumn={0}", this.YearColumn); sb.AppendLine();
            sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
            sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("TinyBlobColumn={0}", this.TinyBlobColumn); sb.AppendLine();
            sb.AppendFormat("MediumBlobColumn={0}", this.MediumBlobColumn); sb.AppendLine();
            sb.AppendFormat("BlobColumn={0}", this.BlobColumn); sb.AppendLine();
            sb.AppendFormat("LongBlobColumn={0}", this.LongBlobColumn); sb.AppendLine();
            sb.AppendFormat("TinyTextColumn={0}", this.TinyTextColumn); sb.AppendLine();
            sb.AppendFormat("MediumTextColumn={0}", this.MediumTextColumn); sb.AppendLine();
            sb.AppendFormat("TextColumn={0}", this.TextColumn); sb.AppendLine();
            sb.AppendFormat("LongTextColumn={0}", this.LongTextColumn); sb.AppendLine();
            sb.AppendFormat("GeometryColumn={0}", this.GeometryColumn); sb.AppendLine();
            sb.AppendFormat("EnumColumn={0}", this.EnumColumn); sb.AppendLine();
            sb.AppendFormat("SetColumn={0}", this.SetColumn); sb.AppendLine();
            sb.AppendFormat("NotNullCharColumn={0}", this.NotNullCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullVarCharColumn={0}", this.NotNullVarCharColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBitColumn={0}", this.NotNullBitColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTinyIntColumn={0}", this.NotNullTinyIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSmallIntColumn={0}", this.NotNullSmallIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullMediumIntColumn={0}", this.NotNullMediumIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullIntColumn={0}", this.NotNullIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBigIntColumn={0}", this.NotNullBigIntColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTinyIntUnsignedColumn={0}", this.NotNullTinyIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSmallIntUnsignedColumn={0}", this.NotNullSmallIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("NotNullMediumIntUnsignedColumn={0}", this.NotNullMediumIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("NotNullIntUnsignedColumn={0}", this.NotNullIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBigIntUnsignedColumn={0}", this.NotNullBigIntUnsignedColumn); sb.AppendLine();
            sb.AppendFormat("NotNullFloatColumn={0}", this.NotNullFloatColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDoubleColumn={0}", this.NotNullDoubleColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDecimalColumn={0}", this.NotNullDecimalColumn); sb.AppendLine();
            sb.AppendFormat("NotNullNumericColumn={0}", this.NotNullNumericColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateColumn={0}", this.NotNullDateColumn); sb.AppendLine();
            sb.AppendFormat("NotNullDateTimeColumn={0}", this.NotNullDateTimeColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTimeColumn={0}", this.NotNullTimeColumn); sb.AppendLine();
            sb.AppendFormat("NotNullYearColumn={0}", this.NotNullYearColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBinaryColumn={0}", this.NotNullBinaryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullVarBinaryColumn={0}", this.NotNullVarBinaryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTinyBlobColumn={0}", this.NotNullTinyBlobColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTinyTextColumn={0}", this.NotNullTinyTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullBlobColumn={0}", this.NotNullBlobColumn); sb.AppendLine();
            sb.AppendFormat("NotNullTextColumn={0}", this.NotNullTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullMediumBlobColumn={0}", this.NotNullMediumBlobColumn); sb.AppendLine();
            sb.AppendFormat("NotNullMediumTextColumn={0}", this.NotNullMediumTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullLongBlobColumn={0}", this.NotNullLongBlobColumn); sb.AppendLine();
            sb.AppendFormat("NotNullLongTextColumn={0}", this.NotNullLongTextColumn); sb.AppendLine();
            sb.AppendFormat("NotNullGeometryColumn={0}", this.NotNullGeometryColumn); sb.AppendLine();
            sb.AppendFormat("NotNullEnumColumn={0}", this.NotNullEnumColumn); sb.AppendLine();
            sb.AppendFormat("NotNullSetColumn={0}", this.NotNullSetColumn); sb.AppendLine();
            sb.AppendFormat("PK_PrimaryKeyColumn={0}", this.PK_PrimaryKeyColumn); sb.AppendLine();
            sb.AppendFormat("PK_TimestampColumn={0}", this.PK_TimestampColumn); sb.AppendLine();
            return sb.ToString();
        }
    }
}
