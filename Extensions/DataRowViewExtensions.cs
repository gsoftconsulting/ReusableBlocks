using System;
using System.Data;

namespace ReusableBlocks.Extensions
{

  /// <summary>
  /// Extension methods for a <see cref="DataRowView"/>.
  /// </summary>
  public static class DataRowViewViewExtensions
  {
    #region GetBoolean

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Boolean"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static bool GetBoolean(this DataRowView row, int columnIndex)
    {
      return (bool)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Boolean"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static bool GetBoolean(this DataRowView row, string columnName)
    {
      return (bool)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Boolean"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static bool? GetNullableBoolean(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (bool)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Boolean"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static bool? GetNullableBoolean(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (bool)row[columnName];
      }
    }

    #endregion

    #region GetByte

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static byte GetByte(this DataRowView row, int columnIndex)
    {
      return (byte)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static byte GetByte(this DataRowView row, string columnName)
    {
      return (byte)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static byte? GetNullableByte(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (byte)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static byte? GetNullableByte(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (byte)row[columnName];
      }
    }

    #endregion

    #region GetBytes

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> array.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static byte[] GetBytes(this DataRowView row, int columnIndex)
    {
      return (byte[])row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> array.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static byte[] GetBytes(this DataRowView row, string columnName)
    {
      return (byte[])row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> array or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static byte[] GetNullableBytes(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (byte[])row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Byte"/> array or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static byte[] GetNullableBytes(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (byte[])row[columnName];
      }
    }

    #endregion

    #region GetChar

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static char GetChar(this DataRowView row, int columnIndex)
    {
      return (char)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static char GetChar(this DataRowView row, string columnName)
    {
      return (char)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static char? GetNullableChar(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (char)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static char? GetNullableChar(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (char)row[columnName];
      }
    }

    #endregion

    #region GetChars

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> array.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static char[] GetChars(this DataRowView row, int columnIndex)
    {
      return (char[])row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> array.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static char[] GetChars(this DataRowView row, string columnName)
    {
      return (char[])row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> array or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static char[] GetNullableChars(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (char[])row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Char"/> array or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static char[] GetNullableChars(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (char[])row[columnName];
      }
    }

    #endregion

    #region GetDateTime

    /// <summary>
    /// Gets the value of the specified column as a <see cref="DateTime"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static DateTime GetDateTime(this DataRowView row, int columnIndex)
    {
      return (DateTime)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="DateTime"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static DateTime GetDateTime(this DataRowView row, string columnName)
    {
      return (DateTime)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="DateTime"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static DateTime? GetNullableDateTime(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (DateTime)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="DateTime"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static DateTime? GetNullableDateTime(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (DateTime)row[columnName];
      }
    }

    #endregion

    #region GetDecimal

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Decimal"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static decimal GetDecimal(this DataRowView row, int columnIndex)
    {
      return (decimal)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Decimal"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static decimal GetDecimal(this DataRowView row, string columnName)
    {
      return (decimal)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Decimal"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static decimal? GetNullableDecimal(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (decimal)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Decimal"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static decimal? GetNullableDecimal(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (decimal)row[columnName];
      }
    }

    #endregion

    #region GetDouble

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Double"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static double GetDouble(this DataRowView row, int columnIndex)
    {
      return (double)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Double"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static double GetDouble(this DataRowView row, string columnName)
    {
      return (double)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Double"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static double? GetNullableDouble(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (double)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Double"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static double? GetNullableDouble(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (double)row[columnName];
      }
    }

    #endregion

    #region GetGuid

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Guid"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static Guid GetGuid(this DataRowView row, int columnIndex)
    {
      return (Guid)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Guid"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static Guid GetGuid(this DataRowView row, string columnName)
    {
      return (Guid)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Guid"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static Guid? GetNullableGuid(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (Guid)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Guid"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static Guid? GetNullableGuid(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (Guid)row[columnName];
      }
    }

    #endregion

    #region GetInt16

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int16"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static short GetInt16(this DataRowView row, int columnIndex)
    {
      return (short)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int16"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static short GetInt16(this DataRowView row, string columnName)
    {
      return (short)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int16"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static short? GetNullableInt16(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (short)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int16"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static short? GetNullableInt16(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (short)row[columnName];
      }
    }

    #endregion

    #region GetInt32

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int32"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static int GetInt32(this DataRowView row, int columnIndex)
    {
      return (int)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int32"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static int GetInt32(this DataRowView row, string columnName)
    {
      return (int)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int32"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static int? GetNullableInt32(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (int)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int32"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static int? GetNullableInt32(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (int)row[columnName];
      }
    }

    #endregion

    #region GetInt64

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int64"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static long GetInt64(this DataRowView row, int columnIndex)
    {
      return (long)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int64"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static long GetInt64(this DataRowView row, string columnName)
    {
      return (long)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int64"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static long? GetNullableInt64(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (long)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Int64"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static long? GetNullableInt64(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (long)row[columnName];
      }
    }

    #endregion

    #region GetSingle

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Single"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static float GetSingle(this DataRowView row, int columnIndex)
    {
      return (float)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Single"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static float GetSingle(this DataRowView row, string columnName)
    {
      return (float)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Single"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static float? GetNullableSingle(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (float)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="Single"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static float? GetNullableSingle(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (float)row[columnName];
      }
    }

    #endregion

    #region GetString

    /// <summary>
    /// Gets the value of the specified column as a <see cref="String"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static string GetString(this DataRowView row, int columnIndex)
    {
      return (string)row[columnIndex];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="String"/>.
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static string GetString(this DataRowView row, string columnName)
    {
      return (string)row[columnName];
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="String"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnIndex">The zero-based index of the column.</param>
    /// <returns>The value of the column.</returns>
    public static string GetNullableString(this DataRowView row, int columnIndex)
    {
      if (row.Row.IsNull(columnIndex))
      {
        return null;
      }
      else
      {
        return (string)row[columnIndex];
      }
    }

    /// <summary>
    /// Gets the value of the specified column as a <see cref="String"/> or null if the value is <see cref="DBNull"/>..
    /// </summary>
    /// <param name="row">The row to retrieve the value from.</param>
    /// <param name="columnName">The name of the column to retrieve.</param>
    /// <returns>The value of the column.</returns>
    public static string GetNullableString(this DataRowView row, string columnName)
    {
      if (row.Row.IsNull(columnName))
      {
        return null;
      }
      else
      {
        return (string)row[columnName];
      }
    }

    #endregion
  }
}
