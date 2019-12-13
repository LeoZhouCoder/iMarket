import React, { Component } from "react";
import {
  Button,
  Form,
  Grid,
  Header,
  Icon,
  Input,
  Message,
  Segment
} from "semantic-ui-react";

export default class LoginForm extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isLogin: true
    };
  }
  getNameInputs = () => {
    if (this.state.isLogin) return null;
    return (
      <Form.Group widths="equal">
        <Form.Field
          fluid
          id="firstName"
          control={Input}
          placeholder="First name"
        />
        <Form.Field
          fluid
          id="lastName"
          control={Input}
          placeholder="Last name"
        />
      </Form.Group>
    );
  };

  getConfirmPassword = () => {
    if (this.state.isLogin) return null;
    return (
      <Form.Input
        fluid
        icon="lock"
        iconPosition="left"
        placeholder="ConfirmPassword"
        type="password"
      />
    );
  };
  getMessage = () => {
    if (this.state.isLogin) {
      return (
        <Message>
          New to us?{" "}
          <a href="#" onClick={this.handleClick}>
            Sign Up
          </a>
        </Message>
      );
    } else {
      return (
        <Message>
          Got an account?{" "}
          <a href="#" onClick={this.handleClick}>
            Sign In
          </a>
        </Message>
      );
    }
  };

  handleClick = () => {
    this.setState({ isLogin: !this.state.isLogin });
  };

  render() {
    return (
      <Grid
        textAlign="center"
        style={{ height: "100vh" }}
        verticalAlign="middle"
      >
        <Grid.Column style={{ maxWidth: 450 }}>
          <Header as="h2" color="teal" textAlign="center">
            <Icon name="chat" color="teal" />
            Let's Chat
          </Header>
          <Form size="large">
            <Segment>
              {this.getNameInputs()}
              <Form.Input
                fluid
                icon="user"
                iconPosition="left"
                placeholder="E-mail address"
              />
              <Form.Input
                fluid
                icon="lock"
                iconPosition="left"
                placeholder="Password"
                type="password"
              />
              {this.getConfirmPassword()}
              <Button color="teal" fluid size="large">
                {this.state.isLogin ? "Login" : "Register"}
              </Button>
            </Segment>
          </Form>
          {this.getMessage()}
        </Grid.Column>
      </Grid>
    );
  }
}
