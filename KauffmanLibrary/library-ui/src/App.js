import React, { Component } from 'react';
import './App.css';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      title: ""
    };
    
    this.saySomething = this.saySomething.bind(this);
    this.receiveData = this.receiveData.bind(this);
};

componentDidMount() {
    var _this = this;
    fetch('https://localhost:44357/api/books', {
      method: "GET",
      mode: "cors"
    })  
  .then(function(response) {
    console.log("response");
      if(response.ok) {
          response.json().then(function(data) {
              console.log(data)
              console.log(data[0].title);
              var title = data[0].title;
              _this.receiveData(title);
              return data[0].title;
          });
      } 
      return null;
  });
}

receiveData(data) {
  this.setState({title: data});
}


  saySomething() {
    return "hi";
  }
  render() {
    const bookTitle = this.state.title;
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <p className="App-intro">
          To get started, edit <code>src/App.js</code> and save to reload.
        </p>
        <div>{this.state.title}</div>
      </div>
    );
  }
}

export default App;
