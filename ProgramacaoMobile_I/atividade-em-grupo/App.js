import React, { Component } from 'react';
import { View, StyleSheet, TextInput, Button, Image } from 'react-native';

class App extends Component {

  constructor(props){
    super(props);

    this.state = {
      usuario:'',
      senha:''
    };

    this.login = this.login.bind(this);
  }

  login(){

    if(this.state.usuario === '' || this.state.senha === ''){
      alert('Preencher usuário e senha!');
    }else{
      alert('Login realizado com sucesso!');
    }
  }

  render(){
    return(

      <View style={styles.container}>

        <Image
          source={{
            uri:'https://cdn-icons-png.flaticon.com/512/3135/3135715.png'
          }}
          style={styles.imagem}
        />

        <TextInput
          style={styles.input}
          placeholder="Usuário:"
          onChangeText={(texto) => this.setState({usuario:texto})}
        />

        <TextInput
          style={styles.input}
          placeholder="Senha:"
          secureTextEntry={true}
          onChangeText={(texto) => this.setState({senha:texto})}
        />

        <View style={styles.botao}>

          <Button
            title="Entrar"
            color="#8aa0b8"
            onPress={this.login}
          />

        </View>

      </View>
    );
  }
}

const styles = StyleSheet.create({

  container:{
    flex:1,
    justifyContent:'center',
    alignItems:'center',
    backgroundColor:'#f2f2f2',
    margin:10,
  },

  botao:{
    width:120,
    marginTop:20,
    borderRadius:10,
    overflow:'hidden',
  },

  input:{
    width:250,
    height:55,
    borderWidth:2,
    borderColor:'#2222',
    borderRadius:12,
    marginBottom:25,
    paddingLeft:15,
    fontSize:22,
    backgroundColor:'#fff',
  },

  imagem:{
    width:120,
    height:120,
    marginBottom:40,
  },
});

export default App;