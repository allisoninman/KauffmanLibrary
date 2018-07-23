import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      title: ""
    };
    
    this.saySomething = this.saySomething.bind(this);
};

componentDidMount() {
    var _this = this;
    fetch('https://localhost:44357/api/books', {
      method: "GET",
      mode: "cors"
    })  
  .then(function(response) {
      if(response.ok) {
          response.json().then(function(data) {
              console.log(data[0].title.toString);
              var title = data[0].title.toString;
              _this.setState({title: title});
              return data[0].title.toString();
          });
      } 
      return null;
  });

}


  saySomething() {
    return "hi";
  }
  render() {
    const bookTitle = this.state.title;
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          To get started, edit <code>src/App.js</code> and save to reload.
        </p>
        <div>{bookTitle}</div>
      </div>
    );
  }
}

export default App;
