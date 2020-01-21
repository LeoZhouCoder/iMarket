import React, { Component } from 'react';
import { Route } from 'react-router';

import { Layout } from './components/Layout';
import LoginForm from './components/LoginForm';
import ChatRoom from './components/ChatRoom';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <LoginForm/>
    );
  }
}
/**
 * <Layout>
        <Route exact path='/' component={LoginForm} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
 * 
 */
