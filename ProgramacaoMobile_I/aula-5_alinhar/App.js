import React from 'react';
import {View, Text} from 'react-native';
function App(){
  return(
    <View style = {{
      flex: 1,
      flexDirection: 'column',
      justifyContent: 'center',
      alignItems: 'center',
      backgroundColor: '#2F4F4F'
      }}>

      <View style = {{width:50, height:50, backgroundColor: '#00FF00'}}></View>
      <View style = {{width:50, height:50, backgroundColor: 'white'}}></View>
      <View style = {{width:50, height:50, backgroundColor: '#b00b69'}}></View>

    </View>
  );
}
export default App;