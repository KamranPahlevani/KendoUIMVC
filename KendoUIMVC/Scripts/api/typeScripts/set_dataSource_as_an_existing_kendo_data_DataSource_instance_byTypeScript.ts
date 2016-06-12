/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="../../typings/kendo-ui/kendo-ui.d.ts" />

namespace set_dataSource_as_an_existing_kendo_data_DataSource_instance_byTypeScript {    
    export class set_dataSource_as_an_existing_kendo_data_DataSource_instance_byTypeScript_Class {
        constructor(public url: string) {
            this.url = url;
        }

        initializeGrid() {
            var dataSource = new kendo.data.DataSource({
                transport: {
                    read: {
                        url: this.url,
                        dataType: 'json'
                    },
                },
                pageSize: 2
            })

            $('#grid').kendoGrid({
                dataSource: dataSource,
                columns: [
                    { field: 'ProductID', title: 'Product ID' },
                    { field: 'ProductName', title: 'Product Name' },
                    { field: 'UnitPrice', title: 'Unit Price' },
                    { field: 'UnitsInStock', title: 'Units In Stock' },
                    { field: 'Discontinued', title: 'Discontinued'}
                ],
                pageable: true
            })
        }
    }
}