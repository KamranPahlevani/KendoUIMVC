
namespace create_a_custom_column_editor_using_the_Kendo_UI_AutoComplete_byTypeScript {
    export class create_a_custom_column_editor_using_the_Kendo_UI_AutoComplete_byTypeScript_Class {
        constructor(public url: string) {
            this.url = url;
        }

        initializeGrid() {
            $('#grid').kendoGrid({
                columns: [
                    { field: 'ProductID' },
                    {
                        field: 'ProductName',
                        editor: function (container, options) {
                            var input = $("<input\>");
                            input.attr('name', options.field);
                            input.appendTo(container);
                            input.kendoAutoComplete({
                                dataTextField: 'ProductName',
                                dataSource: new kendo.data.DataSource({
                                    transport: {
                                        read: {
                                            url: this.url,
                                            dataType: 'json'
                                        }
                                    }
                                })
                            })
                        }
                    },
                    { field: 'UnitPrice' },
                    { field: 'UnitsInStock', groupable: false },
                    { field: 'Discontinued', groupable: true}
                ],
                editable: true,
                dataSource: new kendo.data.DataSource({
                    transport: {
                        read: {
                            url: this.url,
                            dataType: 'json'
                        }
                    }
                })
            })
        }
    }
}