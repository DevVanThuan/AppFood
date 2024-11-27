import { View, Text, StyleSheet } from 'react-native';
import React, { useState } from 'react';
import { TouchableOpacity } from 'react-native';
import Catogories from './Catogories';
import Catogoriesnuoc from './Catogoriesnuoc';
import Catogorieskhaivi from './Catogorieskhaivi';
import Catogoriesmonchinh from './Catogoriesmonchinh';

export default function Menuchoose()  {
    const [showFood, setShowFood] = useState(true);
    const [showDrink, setShowDrink] = useState(false);
    const [showmaindish, setshowmaindish] = useState(false)
    const [showappetizer, setshowappetizer] = useState(false)
    const hienthiFood = () => {// hiển thị thức ăn
      setShowFood(true);
      if (showDrink) 
        {
          setShowDrink(false); // Ẩn nước uống khi thức ăn được mở
          
        }
      if(showappetizer)
        {
          setshowappetizer(false)
        }
      if(showmaindish)
        {
          setshowmaindish(false)
        }
    };
  
    const hienthiDrink = () => {
      setShowDrink(true);
      if (showFood)
        {
           setShowFood(false); // Ẩn thức ăn khi nước uống được mở
        }
      if(showappetizer)
        {
            setshowappetizer(false)
        }
      if(showmaindish)
        {
            setshowmaindish(false)
        }
    };
    const hienthiAppetizer =() =>{
      setshowappetizer(true);
      if(showFood){
        setShowFood(false)
      }
      if(showDrink){
        setShowDrink(false)
      }
      if(showmaindish){
        setshowappetizer(false)
      }
  
    };
    const hienthimaindish =()=>{
      setshowmaindish(true);
      if(showFood){
        setShowFood(false)
      }
      if(showDrink){
        setShowDrink(false)
      }
      if(showappetizer){
        setshowappetizer(false)
      }
    }
  
    return (
      <View style={styles.container}>
        <View style={styles.buttonContainer}>
          <TouchableOpacity onPress={hienthiFood} style={styles.button}>
            <View style={[showFood && styles.viewtext ]}><Text style={[showFood && styles.text  ]}>Thức Ăn</Text></View>
          </TouchableOpacity>
          <TouchableOpacity onPress={hienthiDrink} style={styles.button}>
          <View style={[showDrink && styles.viewtext ]}><Text style={[showDrink && styles.text  ]}>Nước Uống</Text></View>
          </TouchableOpacity>
          <TouchableOpacity onPress={hienthiAppetizer} style={styles.button}>
          <View style={[showappetizer && styles.viewtext ]}><Text style={[showappetizer && styles.text  ]}>Món Khai vị</Text></View>
          </TouchableOpacity>
          <TouchableOpacity onPress={hienthimaindish} style={styles.button}>
          <View style={[showmaindish && styles.viewtext ]}><Text style={[showmaindish && styles.text  ]}>Món Chính</Text></View>
          </TouchableOpacity>
        </View>
        {/*khi showfood đúng thì && là thực hiện lệnh sau && */}
        {showFood && <Catogories></Catogories>} 
        {showDrink && <Catogoriesnuoc></Catogoriesnuoc>}
        {showappetizer && <Catogorieskhaivi></Catogorieskhaivi>}
        {showmaindish && <Catogoriesmonchinh></Catogoriesmonchinh>}
  
  
      </View>
    );
  }
  
  const styles = StyleSheet.create({
    container: {
      flex: 1,
      padding: 10,
    },
    buttonContainer: {
      flexDirection: 'row',
      marginBottom: 10, // khoảng cách giữa nút và catogories
      
    },
    button: {
      padding: 10,
      backgroundColor: '#f0f0f0',
    },
    catogories: {
      marginTop: 10, // khoảng cách cho catogories
    },
    viewtext:{
        
        borderBottomColor:'#8ba8c1',
        borderBottomWidth:1
    },
    text:{
        color:'#8ba8c1',
        marginBottom:5,
        fontWeight:'bold'
    }
  });