import InsertData from "./Component/AddProduct";
import DisplayProducts from "./Component/DisplayProducts";
import DeleteProduct from "./Component/DeleteProduct";

function App() {
  return (
    <div>
      <DisplayProducts></DisplayProducts>
      <InsertData></InsertData>
      <DeleteProduct></DeleteProduct>
      
    </div>
  );
}

export default App;
