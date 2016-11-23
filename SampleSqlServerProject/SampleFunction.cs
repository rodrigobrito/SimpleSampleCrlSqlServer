using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    public const double SaleTax = .086;

    [SqlFunction()]
    public static SqlDouble AddTax(SqlDouble originalAmount)
    {
        SqlDouble taxAmount = originalAmount * SaleTax;
 
        return originalAmount + taxAmount;
    }
}
