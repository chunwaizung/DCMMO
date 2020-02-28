namespace DC
{
    /// <summary>
    /// 放大，计算，缩小到原来的比例，显示
    /// 放大，传输，接收端收到后缩小到原来的比例用来显示或者进行计算
    /// </summary>
    public struct CFloat
    {
        private const int precision = 1000;

        private const double precision_factor = 1.0 / precision;

        private long mValue;

        #region constructor

        public CFloat(long raw, bool h)
        {
            mValue = raw;
        }

        public CFloat(short v)
        {
            mValue = v * precision;
        }

        public CFloat(int v)
        {
            mValue = v * precision;
        }

        public CFloat(long v)
        {
            mValue = v * precision;
        }

        public CFloat(float v)
        {
            mValue = (long) (v * precision);
        }

        public CFloat(double v)
        {
            mValue = (long) (v * precision);
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is CFloat compareObj)
            {
                return this == compareObj || this.mValue == compareObj.mValue;
            }

            return false;
        }

        public override int GetHashCode()
        {
            //todo d.c 相同的值应该获得相同的hashcode
            return base.GetHashCode();
        }

        #region implicit

        public static implicit operator short(CFloat v)
        {
            return v.shortVal();
        }

        public static implicit operator int(CFloat v)
        {
            return v.intVal();
        }

        public static implicit operator long(CFloat v)
        {
            return v.longVal();
        }

        public static implicit operator float(CFloat v)
        {
            return (float)(v.mValue * precision_factor);
        }

        public static implicit operator double(CFloat v)
        {
            return v.mValue * precision_factor;
        }

        public static implicit operator CFloat(short v)
        {
            return new CFloat(v);
        }

        public static implicit operator CFloat(int v)
        {
            return new CFloat(v);
        }

        public static implicit operator CFloat(long v)
        {
            return new CFloat(v);
        }

        public static implicit operator CFloat(float v)
        {
            return new CFloat(v);
        }

        public static implicit operator CFloat(double v)
        {
            return new CFloat(v);
        }
        #endregion

        #region operate

        public static bool operator >(CFloat a, CFloat b)
        {
            return a.mValue > b.mValue;
        }

        public static bool operator <(CFloat a, CFloat b)
        {
            return a.mValue > b.mValue;
        }

        public static bool operator >=(CFloat a, CFloat b)
        {
            return a.mValue >= b.mValue;
        }

        public static bool operator <=(CFloat a, CFloat b)
        {
            return a.mValue >= b.mValue;
        }

        public static bool operator ==(CFloat a, CFloat b)
        {
            return a.mValue == b.mValue;
        }

        public static bool operator !=(CFloat a, CFloat b)
        {
            return a.mValue != b.mValue;
        }

        public static CFloat operator +(CFloat a, CFloat b)
        {
            return new CFloat(a.mValue + b.mValue, true);
        }

        public static CFloat operator -(CFloat a, CFloat b)
        {
            return new CFloat(a.mValue - b.mValue, true);
        }

        public static CFloat operator *(CFloat a, CFloat b)
        {
            return new CFloat(a.mValue * b.mValue, true);
        }

        public static CFloat operator /(CFloat a, CFloat b)
        {
            return new CFloat(a.mValue / b.mValue, true);
        }

        public static CFloat operator -(CFloat a)
        {
            return new CFloat(-a.mValue, true);
        }

        #endregion

        #region convert

        public short shortVal()
        {
            return (short) (mValue / precision);
        }

        public int intVal()
        {
            return (int)(mValue / precision);
        }

        public long longVal()
        {
            return (long)(mValue / precision);
        }

        public float floatVal()
        {
            return (float)(mValue * precision_factor);
        }

        public double doubleVal()
        {
            return (double)(mValue * precision_factor);
        }

        #endregion
    }
}