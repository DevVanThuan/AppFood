import { View, Image, StyleSheet, Text } from 'react-native'
import React from 'react'
import { ICONS } from './FoodImage/FoodData'
import { TouchableOpacity } from 'react-native'
import Catogories from '../components/Catogories'
import Menuchoose from '../components/Menuchoose'
import Time_and_local from '../components/Time_and_local'
//hello ádasádasdasd65546554
export default function index() {
  return (
    <View style={styles.container}>
      <Image style={styles.image} source={ICONS.hinhnen}></Image>
      <View style={styles.header}>
      <TouchableOpacity>
        <View style={styles.circleButton}>
          <Image style={styles.icon} source={ICONS.back}></Image>
        </View>
        </TouchableOpacity>
        <View style={styles.headerIcons}>
        <TouchableOpacity>
        <View style={styles.circleButton}>
            <Image style={styles.icon} source={ICONS.like}></Image>
          </View>
          </TouchableOpacity>
        <TouchableOpacity>
            <View style={styles.circleButton}>
            <Image style={styles.icon} source={ICONS.share}></Image>
            </View>
        </TouchableOpacity>
        </View>
      </View>
      <View style={styles.viewimagelogo}>
      <TouchableOpacity>
        <Image style={styles.imagelogo} source={ICONS.logo}></Image>
      </TouchableOpacity>
      <View style={styles.viewtext}>
        <Text style={styles.text1}>Gadana - Chân Gà Cay</Text>
        <Text style={styles.text2}>8:00-23:00 (T2-CN)</Text>
      </View>
      </View>
      <Time_and_local></Time_and_local>
      <Menuchoose></Menuchoose>
    </View>
  )
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
      paddingBottom:'20%'
    },
    image: {
      width: '100%',
      height: 250, 
    },
    header: {
      position: 'absolute',
      top: 0,
      width: '100%',
      flexDirection: 'row',
      justifyContent: 'space-between',
      alignItems: 'center',
      paddingHorizontal: 10,
      paddingVertical: 100,
    },
    headerIcons: {
      flexDirection: 'row',
    },
    circleButton: {
      width: 40, 
      height: 40,
      borderRadius: 20, 
      backgroundColor: 'rgba(0, 0, 0, 0.5)', 
      justifyContent: 'center',  
      alignItems: 'center',       
      marginHorizontal: 5,            
    },
    icon: {
      width: 24,
      height: 24,
      tintColor: 'white',         
    },
    viewimagelogo:{
        flexDirection:'column',
        alignItems:'center'
    },
    imagelogo:{
        height:150,
        width:150,
        borderRadius:100,
        borderColor: 'white',
        borderWidth: 2,  
        marginTop:'-20%',
    },
    viewtext:{
        marginTop:10,
        marginBottom:10,
        alignItems:'center'
    },
    text1:{
        fontSize:20,
        fontWeight:'bold',
        marginBottom:5
    },
    text2:{
        color:'#b9b9b9'
    }
  })
  