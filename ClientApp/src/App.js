import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Administration } from './components/Administration.tsx';
import { Search } from './components/Search';

import './custom.css'
import '../node_modules/@syncfusion/ej2-base/styles/fabric.css';  
import '../node_modules/@syncfusion/ej2-buttons/styles/fabric.css';  
import '../node_modules/@syncfusion/ej2-calendars/styles/fabric.css';  
import '../node_modules/@syncfusion/ej2-dropdowns/styles/fabric.css';  
import '../node_modules/@syncfusion/ej2-inputs/styles/fabric.css';  
import '../node_modules/@syncfusion/ej2-navigations/styles/fabric.css';
import '../node_modules/@syncfusion/ej2-popups/styles/fabric.css';
import '../node_modules/@syncfusion/ej2-splitbuttons/styles/fabric.css';
import "../node_modules/@syncfusion/ej2-react-grids/styles/fabric.css";

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route path='/administration' component={Administration} />
        <Route path='/search' component={Search} />
      </Layout>
    );
  }
}
