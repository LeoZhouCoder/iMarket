import React, { Component } from "react";
import {
  Button,
  Form,
  Grid,
  Header,
  Icon,
  Message,
  Segment
} from "semantic-ui-react";

export default class ChatRoom extends Component {
  constructor(props) {
    super(props);
    this.state = {
    };
  }

  render() {
    return (
      <div>
        <h1>ChatRoom</h1>
        <p>This is a simple example of a React component.</p>
      </div>
    );
  }
}
