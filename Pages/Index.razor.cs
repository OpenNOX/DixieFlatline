namespace DixieFlatline.Pages;

using DixieFlatline.Models;
using Microsoft.AspNetCore.Components;

public partial class Index : ComponentBase
{
    private Column newColumn = new();

    private List<Column> columns = new();

    private void HandleValidSubmit()
    {
        columns.Add(newColumn);

        newColumn = new();
    }
}
