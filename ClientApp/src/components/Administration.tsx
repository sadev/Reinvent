import { ColumnDirective, ColumnsDirective, GridComponent } from '@syncfusion/ej2-react-grids';
import { Edit, EditSettingsModel, Inject, Toolbar, ToolbarItems } from '@syncfusion/ej2-react-grids';
import { DataManager } from '@syncfusion/ej2-data';
import * as React from 'react';

export default class App extends React.Component<{}, {}> {
  public editOptions: EditSettingsModel = { allowEditing: true, allowAdding: true, allowDeleting: true };
  public toolbarOptions: ToolbarItems[] = ['Add', 'Edit', 'Delete', 'Update', 'Cancel'];
  public data = new DataManager({
    url: 'synonym'
  });

  public render() {
    return <GridComponent dataSource={this.data} editSettings={this.editOptions} toolbar={this.toolbarOptions} height={265}>
        <ColumnsDirective>
            <ColumnDirective field='OrderID' headerText='Order ID' width='100' textAlign="Right" isPrimaryKey={true}/>
            <ColumnDirective field='CustomerID' headerText='Customer ID' width='120'/>
            <ColumnDirective field='Freight' headerText='Freight' width='120' format="C2" textAlign="Right"/>
            <ColumnDirective field='ShipCountry' headerText='Ship Country' width='150'/>
        </ColumnsDirective>
        <Inject services={[Edit, Toolbar]} />
    </GridComponent>
  }
}
