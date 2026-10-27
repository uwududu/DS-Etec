import React from 'react';
import {View, Text, Image, StyleSheet} from 'react-native';
function App (){
 return(
    <View style = {styles.conteiner}> 
        <Text style = {styles.titulo}>
        Restaurante
        </Text>

        <View style = {styles.card1}> 
          <Image source = {require ('/assets/lasanha.jpeg')}style = {styles.imagem}/>
          <Text style = {styles.nomePlate}> Lasanha </Text>
        </View>
        <View style = {styles.card1}> 
          <Image source = {require ('/assets/pizza.jpg')}style = {styles.imagem}/>
          <Text style = {styles.nomePlate}> Pizza de Frango </Text>
        </View>

        <Text style = {styles.nomeAluno}>
          By: Eduardo
        </Text>

    </View>
  );
}
const styles = StyleSheet.create({
  conteiner:{
    flex: 1,
    alignItems: 'center',
    marginTop: 26,
    backgroundColor: '#280137',
    gap: 35
  },
  titulo:{
    fontSize: 35,
    fontWeight: 'bold',
    color: 'white',
    textAlign: 'center',
  },
  card1:{
    width: 280,
    backgroundColor: '#b00b69',
    borderColor: '#b00b69',
    borderRadius: 14,
    padding: 12,
    alignItems: 'center'
  },
  imagem:{
    width: 250,
    height:150,
    borderRadius:14,
  },
  nomePlate:{
    marginTop: 10,
    fontSize: 20,
    fontWeight: 'bold',
  },
  nomeAluno:{
    fontSize: 25,
    fontStyle: 'Italic',
    marginTop: 10,
    color: 'white'
  },
});
export default App;