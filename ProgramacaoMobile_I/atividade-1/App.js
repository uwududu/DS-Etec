//Importa a biblioteca principal do React
import React, { Component } from 'react';
//Importa componentes prontos do React Native
//View = container (tipo uma div)
//Text = exibit textos
//Image = exibir imagens
import { StyleSheet, View, Text, Image} from 'react-native';
//Cria uma classe chamada App que herda de Component
//Todo componente de classe precisa estender Component
class App extends Component{
//metodo obrigatorio que renderiza o que aparece na tela
  render(){
//variavel q guarda um nome
    let nome = 'steve trabalhos k';
//variavel com o link da imagem q sera exibida
    let img1 = 'https://sujeitoprogramador.com/steve.png';
//o return define o layout da tela
    return(
//view e um container q agrupa os elementos da interface
      <View>
{/*Text para mostrar "Hello World" - fontSize aumenta o tamanho da fonte - textAlign: 'center' centraliza o texto */}
        <Text style = {{color: '#b00b69', fontSize:25, fontFamily:'Comic Sans Ms', textAlign: 'center'}}> Ola Mundo!!! </Text>
        <Text style = {{color: '#b00b69', fontSize:25, fontFamily:'Comic Sans MS', textAlign: 'center'}}> Meu Primeiro App </Text>
        <Text style = {{color: '#b00b69', fontSize:25, fontFamily:'Comic Sans MS', textAlign: 'center'}}> Sujeito Programador </Text>
        <Image source = {{ uri: img1}} style = {{ width:300,height:300,margin:20}}/>

        <Text style = {{color: '#b00b69', fontSize:25,fontFamily:'Comic Sans MS',  textAlign: 'center'}}> {nome} </Text>
      </View>
    );
  }
}
//exporta o componente App para q ele possa ser usado no projeto
export default App;