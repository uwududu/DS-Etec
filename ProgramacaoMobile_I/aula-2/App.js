import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
function App() {
  return (
    <View style = {styles.container}>
      <Text style = {styles.text1}> Primeira Frase </Text>
      <Text style = {styles.text2}> Segunda Frase </Text>
      <Text style = {styles.text3}> Terceira Frase </Text>
      <Text style = {styles.text4}> Quarta Frase </Text>
    </View>
  );
}
const styles = StyleSheet.create({
  container:{
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#250033',
  },
  text1:{
    fontSize:30,
    color: '#b00b69',
    fontFamily: 'Comic Sans MS',
  },
    text2:{
    fontSize:28,
    color: '#b00b69',
    fontFamily: 'Comic Sans MS',
  },
    text3:{
    fontSize:26,
    color: '#b00b69',
    fontFamily: 'Comic Sans MS',
  },
    text4:{
    fontSize:24,
    color: '#b00b69',
    fontFamily: 'Comic Sans MS',
  },
})


export default App;