/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="../../typings/kendo-ui/kendo-ui.d.ts" />

namespace specify_detail_template_as_a_function_byTypeScript {
    export class specify_detail_template_as_a_function_byTypeScript_Class {
        constructor() {
        }

        initializeGrid() {
            $('#grid').kendoGrid({
                columns: [
                    { field: 'name' },
                    {field: 'age'}
                ],
                dataSource: [
                    { name: 'Jane Doe', age: 30 },
                    { name: 'John Doe', age: 33}
                ],
                detailTemplate: kendo.template($('#detail-template').html())
            });
        }
    }
}