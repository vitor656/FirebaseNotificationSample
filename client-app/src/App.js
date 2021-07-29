import React, { Component } from 'react';
import './App.css';
import firebase from './firebase';

export default class App extends Component {
  constructor(props) {
    super(props);
    this.state = {

    }
  }

  componentDidMount() {
    const messaging = firebase.messaging();
    Notification.requestPermission().then(() => {
      return messaging.getToken();
    }).then(token => {
      console.log(token);
    });
  }

  render() {
    return (
      <div>

      </div>
    )
  }
}
