import { View, Text, FlatList, StyleSheet } from 'react-native'
import React from 'react'
import { FontAwesome, FontAwesome6 } from '@expo/vector-icons';
import { MONKHAIVI } from '../app/FoodImage/FoodData';
import { TouchableOpacity } from 'react-native';
import { Image } from 'react-native';

export default function Catogorieskhaivi() {
    const ngoisao = [];
    for (let i = 0; i < 5; i++) {
        ngoisao.push(
            <FontAwesome
                key={i}
                name='star'
                size={12}
                color={'#ffcc00'}
                style={{ marginRight: 2 }} 
            />
        );
    }

    return (<View>
        <Text style={{marginLeft:10, fontWeight:'bold', fontSize:20}}>Món Khai Vị</Text>
        <FlatList
            data={MONKHAIVI}
            renderItem={({ item }) => {
                return (
                    <View style={styles.containerss}>
                    <View style={styles.containers}>
                    <TouchableOpacity>
                        <View style={styles.container}>
                            <Image style={styles.img} source={item.icon} />
                            <View style={styles.textright}>
                                <Text>{item.name}</Text>
                                <View style={styles.viewstar}>
                                    <View style={styles.viewstar}>{ngoisao}</View>
                                    <Text>4.1</Text>
                                </View>
                                <View style={styles.viewprice}>
                                    <Text style={styles.price}>35.000đ</Text>
                                    <Text style={styles.oldPrice}>60.000đ</Text>
                                </View>
                                <View style={styles.viewtextnd}>
                                    <Text style={styles.textnd}>1 đã bán</Text>
                                    <View style={styles.viewtextrd}>
                                        <Text style={styles.textrd}>Giảm 30%</Text>
                                    </View>
                                </View>
                            </View>
                        </View>
                        </TouchableOpacity>
                        <TouchableOpacity style={styles.viewadd}>
                            <FontAwesome6 name="add" size={18} color="white" />
                        </TouchableOpacity>
                        </View>
                    </View>
                );
            }}
            keyExtractor={item => item.id.toString()} 
        />
        </View>
    );
}

const styles = StyleSheet.create({
    containerss: {
        flex: 1,
        flexDirection: 'row',
        marginRight:10,
        marginLeft:10
    },
    containers:{
        width:'100%',
        paddingTop:20,
        paddingBottom:20,
        position: 'relative', // Để sử dụng position absolute cho viewadd
        borderBottomColor:'gray',
        borderBottomWidth:0.2
    },
    container: {
        
        flex: 1,
        flexDirection: 'row',
        
    },
    viewstar: {
        flexDirection: 'row',
        alignItems: 'center',
    },
    img: {
        height: 100,
        width: 100,
        marginRight: 10,
    },
    textright: {},
    viewprice: {
        flexDirection: 'row',
        alignItems: 'center',
    },
    price: {
        color: 'red',
        fontWeight: 'bold',
        fontSize: 20,
        marginRight: 5,
    },
    oldPrice: {
        fontSize: 13,
        textDecorationLine: 'line-through',
        color: 'gray',
    },
    viewtextnd: {
        flexDirection: 'row',
        alignItems: 'center',
    },
    textnd: {
        color: 'gray',
        marginRight: 10,
    },
    viewtextrd: {
        borderRadius: 20,
        borderColor: '#8ba8c1',
        borderWidth: 2,
        padding: 3,
    },
    textrd: {
        fontSize: 12,
        color: '#8ba8c1',
    },
    viewadd: {
        position: 'absolute', // Để định vị nút "Thêm"
        bottom: 10, // Khoảng cách từ đáy
        right: 10, // Khoảng cách từ bên phải
        width: 30, // Đặt kích thước cho nút
        height: 30,
        backgroundColor: '#296a9d',
        borderRadius: 20,
        justifyContent: 'center',
        alignItems: 'center',
    },
});
