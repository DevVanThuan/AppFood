import { View, Text, Image, StyleSheet, TouchableOpacity, Alert } from 'react-native'
import React from 'react'
import { FontAwesome } from '@expo/vector-icons'
import { ICONS } from '../app/FoodImage/FoodData'
import { Linking } from 'react-native';

export default function Time_and_local() {

  const openMap = () => {
    /*const latitude = 10.932556; 
    const longitude = 106.861694;
    const url = `https://www.google.com/maps/search/?api=1&query=${latitude},${longitude}`;
    nếu viết máy k hiểu vị trí phải tách riêng ra để map có thể nhận diện tọa độ 
    */
    const location = [10.932556, 106.861694];
    const url = `https://www.google.com/maps/search/?api=1&query=${location}`;
    Linking.openURL(url)
    .catch((loi) => console.error('Lỗi khi mở Google Maps',loi));
  
  };
  return (
    <View style={styles.container}>
      <View style={styles.view}>
        <View style={{flexDirection:'row',alignItems:'center',marginBottom:5}}>
        <FontAwesome
              
              name='star'
              size={20}
              color={'#ffcc00'}
              style={{ marginRight: 2 }} 
          />
        <Text style={{fontWeight:'bold'}}>4.1</Text>
        </View>
        
        <Text style={styles.textdanhgia}>(50+đánh giá)</Text>
      </View>
      <View style={styles.view}>
      <TouchableOpacity onPress={openMap} style={{alignItems:'center'}}>
        <Image source={ICONS.location} style={styles.icon}></Image>
        <Text style={styles.textdanhgia}>Địa Chỉ Quán</Text>
        </TouchableOpacity>
      </View>
      <View style={styles.view}>
        <View style={{flexDirection:'row', alignItems:'center'}} >
            <Image style={styles.icon1} source={ICONS.clock}></Image>
            <Text style={{color:'#747474',fontWeight:'bold'}}>11-20 phút</Text>
        </View>
        <Text style={styles.textdanhgia}>Dự Kiến Giao</Text>
      </View>
    </View>
  )
}
const styles = StyleSheet.create({
    container:{
        flexDirection:'row',
        padding:20
    },
    view:{
        flexDirection:'column',
        alignItems:'center',
        borderRightColor:'gray',
        borderRightWidth:0.5,
        paddingRight:10,
        marginRight:10,
        height:'130%',
        width:'33.33%'
    },
    icon:{
        width:20,
        height:20,
        tintColor:'#fb7b63',
        marginBottom:5,
        
    },
    icon1:{
        width:20,
        height:20,
        tintColor:'#1c648f',
        marginBottom:5,
        marginRight:5
    },

    textdanhgia:{
        fontWeight:'bold'
    },

       

})