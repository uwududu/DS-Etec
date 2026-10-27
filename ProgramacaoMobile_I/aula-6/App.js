//TextInput: é um dos componentes mais importantes do React Native, porque abre caminho para: formularios, login, cadastro, pesquisas, interação com o banco de dados//
import React, {Component} from 'react';
import {View, Text, StyleSheet, TextInput} from 'react-native';
class App extends Component{
  //constructor
  constructor (props){
    super(props);
    this.state = {
      nome: ''
    };
    //bind pegaNome
  this.pegaNome = this.pegaNome.bind(this);
  }
  //pega texto digitado
  pegaNome (texto){
    this.setState({nome: texto});
  }

render(){
  return(
    //main view
    <View style = {styles.container}>
      <TextInput
        style = {styles.input}
        placeholder = "ass: "
        onChangeText = {this.pegaNome}
      />

      <Text style = {styles.texto}>
      bem vindo {this.state.nome}
      </Text>

    </View>
  );
}
}

//criar  estilos do trem
const styles = StyleSheet.create({
  container:{
    flex:1,
  },

  input:{
    height:45,
    borderWidth:1,
    borderColor: '#b00b69',
    margin:10,
    padding:10,
  },

  texto:{
    textAlign:'center',
    fontSize:25,
  },
});
export default App;