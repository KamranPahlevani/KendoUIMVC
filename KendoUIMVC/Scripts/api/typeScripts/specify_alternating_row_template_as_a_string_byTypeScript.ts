/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="../../typings/kendo-ui/kendo-ui.d.ts" />


namespace specify_alternating_row_template_as_a_string_byTypeScript {
    export class specify_alternating_row_template_as_a_string_byTypeScript_Class {
        constructor() {
        }

        initializeGrid() {
            $('#grid').kendoGrid({
                dataSource: [
                    { name: 'Jane Doe', age: 30 },
                    {name: 'John Doe', age: 33}
                ],
                altRowTemplate: '<tr data-uid="#= uid #"><td><strong>#: name #</strong></td><td><strong>#: age #</strong></td></tr>'
            })
        }
    }
}