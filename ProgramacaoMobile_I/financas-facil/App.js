import { View, Text, StyleSheet, Image, Button, ScrollView } from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

//Tela Incial
function HomeScreen({ navigation }){
 
 return (
   <ScrollView contentContainerStyle={styles.container}>
    <Image
     source={require('./assets/images.png')}
     style={styles.logo}
    />

    <Text style={styles.titulo}>
      Finanças Fácil
    </Text>

    <View style={styles.botao}>
      <Button
        title="INVESTIMENTOS"
        onPress={() => navigation.navigate('Investimentos')}
      />
    </View>

    <View style={styles.botao}>
      <Button
        title="ÍNDICES FINANCEIROS"
        onPress={() => navigation.navigate('Indices Financeiros')}
      />
    </View>
    <View style={styles.botao}>
      <Button
        title="Bitcoin"
        onPress={() => navigation.navigate('Bitcoin')}
      />
    </View>

    <Text style={styles.frase}>
      Investir em conhecimento rende sempre os melhores juros.
    </Text>

   </ScrollView>
 );
}

const Stack = createNativeStackNavigator();

//Aplicação Principal
export default function App(){
   return(
     <NavigationContainer>
      <Stack.Navigator initialRouteName="Home">
        <Stack.Screen
          name="Home"
          component={HomeScreen}
          options={{ title: 'Finanças Fácil' }}
        />
        <Stack.Screen
          name="Investimentos"
          component={InvestimentosScreen}
          options={{ title: 'Investimentos' }}
        />
        <Stack.Screen
          name="Indices Financeiros"
          component={IndicesScreen}
          options={{ title: 'Indices' }}
        />
        <Stack.Screen
          name="Bitcoin"
          component={BitcoinScreen}
          options={{ title: 'Bitcoin' }}
        />
      </Stack.Navigator>      
     </NavigationContainer>
  );
}

//Tela de Investimentos
  function InvestimentosScreen(){
    return(
      <ScrollView contentContainerStyle={styles.container}>
        <Text style={styles.titulo}>
          Minha Página de Investimentos.
        </Text>

        <Text style={styles.texto}>
          Aqui você poderá colocar informações sobre investimentos.
        </Text>

        <Text style={styles.texto}>
         Exemplos: Poupança, CDB, Tesouro Direto, Fundos de Investimentos, Ações.
        </Text>
      </ScrollView>
    );
  }

  function IndicesScreen(){
    return(
      <ScrollView contentContainerStyle={styles.container}>
        <Text style={styles.titulo}>
          Minha Página de Indices Financeiros.
        </Text>

        <Text style={styles.texto}>
          Aqui você poderá colocar informações sobre indices financeiros.
        </Text>

        <Text style={styles.texto}>
         Indices financeiros de bancos sao medidas usadas para avaliar a saude, a segurança e a eficiencia de uma instituiçao financeira
        </Text>
      </ScrollView>
    );
  }

  function BitcoinScreen(){
    return(
      <ScrollView contentContainerStyle={styles.container}>
        <Text style={styles.titulo}>
          Minha Página de Indices Financeiros.
        </Text>

        <Text style={styles.texto}>
          Aqui você poderá colocar informações sobre Bitcoin.
        </Text>

        <Text style={styles.texto}>
         O Bitcoin é a primeira e mais famosa moeda digital descentralizada do mundo, funcionando sem o controle de bancos centrais ou governos.
        </Text>
      </ScrollView>
    );
  }

const styles = StyleSheet.create({
  container:{
    flexGrow:1,
    justifyContent:'center',
    alignItems:'center',
    backgroundColor:'#F5F5F5',
    padding:20
  },

  logo:{
    width:150,
    height:150,
    marginBottom:10
  },

  titulo:{
    fontSize:32,
    fontWeight:'bold',
    color:'#1E3A8A'
  },

  frase:{
    fontSize:12,
    fontStyle: 'italic',
    textAlign: 'center',
    color:'#5AD1EE'
  },

  botao:{
    marginBottom: 15,
    width: 220,
    marginTop:10
  }


});