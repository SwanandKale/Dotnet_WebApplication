import { useState } from "react";
import axios from "axios";
const DeleteData = () => {

    const[apidata,SetApiData]=useState({id:""});

    const handleChange=(event)=>
    {
        const{name,value}=event.target;
        SetApiData({...apidata,[name]:value});
    }

    const deletedata=(event)=>
    {
        
        axios.delete(`http://localhost:5190/api/product/${apidata.id}`);
    }


    return (
        <div>
            <br></br>
            <h3>Enter Id to Delete Product</h3>
            <form method="GET" onSubmit={deletedata}>
                <input type="text" name="id" placeholder="Enter Id" onChange={handleChange}></input>
                <button type="submit">Delete</button>
            </form>
        </div>
    );
}
export default DeleteData;