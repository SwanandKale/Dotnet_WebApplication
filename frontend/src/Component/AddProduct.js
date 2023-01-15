import { useState } from "react";
import axios from "axios";
const InsertData=()=>
{
    const [apiData,setApiData]=useState({id:"",name:"",price:""});

    const handleChange=(event)=>
    {
        
        const{name,value}=event.target;
        setApiData({...apiData,[name]:value});
    }

    const saveData=(event)=>
    {
        console.log(apiData);
        event.preventDefault();
        axios.post("http://localhost:5190/api/product",apiData);
    }

    


    return(
        <div>
            <br></br>
            <form method="post" onSubmit={saveData}>
                <label htmlFor="id">Product Id &nbsp; </label>
                <input name="id" id="id" placeholder="Enter Id : " onChange={handleChange}></input>&nbsp;

                <label htmlFor="name">Product Name&nbsp; </label>
                <input name="name" id="name" placeholder="Enter Name : " onChange={handleChange}></input>&nbsp;

                <label htmlFor="price">Product Price&nbsp; </label>
                <input name="price" id="price" placeholder="Enter Price" onChange={handleChange}></input>&nbsp;

                <button type="submit">Submit Data</button>
            </form>
            <br></br>

        </div>
    );
}
export default InsertData;