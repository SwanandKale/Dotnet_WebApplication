import { useState, useEffect } from "react";
import axios from "axios";

const SendData = (props) => {
    const [apiData, setApiData] = useState([]);

    useEffect(
        () => {
            axios.get("http://localhost:5190/api/product").then(response => { setApiData(response.data) });
        }
    )


    const displaydata = apiData.map(product => {
        return (
            <tr>
                <td>{product.id}</td>
                <td>{product.name}</td>
                <td>{product.price}</td>
            </tr>
        );
    });







    return (
        <table>
            <tr>
                <td>Product Id</td>
                <td>Product Name</td>
                <td>Product Price</td>
            </tr>
            {displaydata}
        </table>
    );
}
export default SendData;