using CsvDataAccess.CsvReading;
using CsvDataAccess.Interface;
using CsvDataAccess.OldSolution;

namespace CsvDataAccess.NewSolution;

public class FastTableDataBuilder : ITableDataBuilder
{
    public ITableData Build(CsvData csvData)
    {
        var resultRows = new List<FastRow>();

        foreach (var row in csvData.Rows)
        {
            var newRowData = new Dictionary<string, object>();

            for (int columnIndex = 0; columnIndex < csvData.Columns.Length; ++columnIndex)
            {
                var column = csvData.Columns[columnIndex];
                string valueAsString = row[columnIndex];
                object value = ConvertValueToTargetType(valueAsString);

                if (value is not null)
                {
                    newRowData[column] = value;
                }
            }

            resultRows.Add(new FastRow(newRowData));
        }

        return new FastTableData(csvData.Columns, resultRows);
    }

    private object ConvertValueToTargetType(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }
        if (value == "TRUE")
        {
            return true;
        }
        if (value == "FALSE")
        {
            return false;
        }
        if (value.Contains(".") && decimal.TryParse(value, out var valueAsDecimal))
        {
            return valueAsDecimal;
        }
        if (int.TryParse(value, out var valueAsInt))
        {
            return valueAsInt;
        }
        return value;
    }
}

public class FastRow
{
    private Dictionary<string, object> _data;

    public FastRow(Dictionary<string, object> data)
    {
        _data = data;
    }

    public object GetAtColumn(string columnName)
    {
        if (_data.ContainsKey(columnName))
        {
            return _data[columnName];
        }

        return null;
    }
}

public class FastTableData : ITableData
{
    private readonly List<FastRow> _rows;
    public int RowCount => _rows.Count;
    public IEnumerable<string> Columns { get; }

    public FastTableData(IEnumerable<string> columns, List<FastRow> rows)
    {
        _rows = rows;
        Columns = columns;
    }

    public object GetValue(string columnName, int rowIndex)
    {
        return _rows[rowIndex].GetAtColumn(columnName);
    }
}