// 1. Importar a biblioteca do React:
import React from 'react';

// 2. Importar os componentes que serão utilizados no projeto:
import {View, Text} from 'react-native';

// 3. Criar uma função:
function App(){
  return(
    <View style = {{
      marginTop: 60,
      alignItems: 'center'
    }}>
      <Text> Bem vindo a ETEC!</Text>
      <Text> Eduardo</Text>
    </View>
  );
}
// 4. Após criar o componente, é preciso exportá-lo:
export default App;
