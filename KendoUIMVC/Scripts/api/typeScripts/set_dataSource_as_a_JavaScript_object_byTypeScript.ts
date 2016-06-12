/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="../../typings/kendo-ui/kendo-ui.d.ts" />

module set_dataSource_as_a_JavaScript_object_byTypeScript {
    $("#grid").kendoGrid({
        columns: [
            { field: 'name' },
            { field: 'age' }
        ],
        dataSource: [
            { name: "Jane Doe", age: 30 },
            { name: "John Doe", age: 33 }
        ]
    })
}

