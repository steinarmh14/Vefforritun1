using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionTest
{
    class Fraction
    {

    public Fraction( )
    {
        
    }

    private int m_nNumerator = 0;
    private int m_nDenominator = 1;
    public Fraction( String strFraction )
    {

    // Ensure the format is correct (i.e. "numerator/denominator":
    int nSlashPos = strFraction.IndexOf( "/" );
    if (nSlashPos == -1)
        {
            throw new ArgumentException( );
        }
            m_nNumerator = Convert.ToInt32(strFraction.Substring(0,nSlashPos));
            m_nDenominator = Convert.ToInt32(strFraction.Substring(nSlashPos + 1));
            Normalize();
    }

    public void Normalize()
    {
        int a1 = 0;
        int b1 = 0;
        int a2 = 0;
        int f = 0;
        a1 = m_nNumerator;
        b1 = m_nDenominator;
        while (true)
        {
            if ((a2 = a1 % b1) == 0)
            {
                f = b1;
                break;
            }
            if ((b1 = b1 % a1) == 0)
            {
                f = a1;
                break;
            }
            a1 = a2;
        }
        m_nNumerator /= f;
        m_nDenominator /= f;
        if (m_nDenominator < 0)
        {
            m_nNumerator = -m_nNumerator;
            m_nDenominator = -m_nDenominator;
        }
    }

    public override string ToString()
    {
        return String.Format("{0}/{1}", m_nNumerator, m_nDenominator);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        Fraction result = new Fraction();
        result.m_nNumerator = (a.m_nNumerator * b.m_nDenominator)
        + (a.m_nDenominator * b.m_nNumerator);
        result.m_nDenominator = a.m_nDenominator * b.m_nDenominator;
        result.Normalize();
        return result;
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        Fraction result = new Fraction();
        result.m_nNumerator = (a.m_nNumerator * b.m_nDenominator)
        - (a.m_nDenominator * b.m_nNumerator);
        result.m_nDenominator = a.m_nDenominator * b.m_nDenominator;
        result.Normalize();
        return result;    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        Fraction result = new Fraction();
        result.m_nNumerator = (a.m_nNumerator * b.m_nNumerator);
        result.m_nDenominator = (a.m_nDenominator * a.m_nDenominator);
        return result;
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        Fraction result = new Fraction();
        result.m_nNumerator = (a.m_nNumerator * b.m_nDenominator);
        result.m_nDenominator = (a.m_nDenominator * b.m_nNumerator);
        return result;
    }
//Normalize is the next funct
    }
}
