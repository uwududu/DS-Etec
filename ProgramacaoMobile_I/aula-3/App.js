import React, { Component } from 'react';
import { View, Text } from 'react-native';

class Exemplo01 extends Component{
  render(){
    return(
      <View style={{flex:1, backgroundColor:'#b00b69'}}>
        <View style={{flex:2, backgroundColor: '#b00b69'}}> </View>
        <View style={{flex:1, backgroundColor: '#29012e'}}> </View>
        <View style={{flex:2, backgroundColor: '#B0E0E6'}}> </View>
      </View>
    );
  }
}
export default Exemplo01;